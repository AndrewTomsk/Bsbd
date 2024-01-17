using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace WarehouseAdmin
{
    public class Database
    {
        private string _connectionString = Properties.Settings.Default.connection;
        private string _exception = "Данные введены неверно!";
        public void Execute(string sqlSelect, string exception, string success)
        {
            // Используем using для автоматического освобождения ресурсов соединения
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    // Открываем соединение
                    connection.Open();
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Ошибка подключения к базе данных", "Ошибка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
                // Создаем команду с параметризованным запросом
                using (SqlCommand command = new SqlCommand(sqlSelect, connection))
                {
                    try
                    {
                        // Выполняем SQL запрос
                        command.ExecuteNonQuery();
                        MessageBox.Show(success);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(exception, "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public void Execute(string sqlSelect, string exception)
        {
            // Используем using для автоматического освобождения ресурсов соединения
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    // Открываем соединение
                    connection.Open();
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Ошибка подключения к базе данных", "Ошибка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
                // Создаем команду с параметризованным запросом
                using (SqlCommand command = new SqlCommand(sqlSelect, connection))
                {
                    try
                    {
                        // Выполняем SQL запрос
                        command.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(exception, "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public DataTable FillDataGridView(string sqlSelect)
        {
            //Создаем объект connection класса SqlConnection для соединения с БД
            //CafeConnectionString – строка описания соединения с источником данных
            try
            {
                SqlConnection connection = new
                SqlConnection(_connectionString);
                //Создаем объект command для SQL команды
                SqlCommand command = connection.CreateCommand();
                //Заносим текст SQL запроса через параметр sqlSelect
                command.CommandText = sqlSelect;
                //Создаем объект adapter класса SqlDataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter();
                //Задаем адаптеру нужную команду, в данном случае команду Select
                adapter.SelectCommand = command;
                //Создаем объект table для последующего отображения результата запроса
                DataTable table = new DataTable();
                //заполним набор данных результатом запроса
                adapter.Fill(table);
                return table;
            }
            catch (Exception)
            {
            }
            return null;
        }
        public void AddStuff(string name, string surname, string position,
                             string salary, string password, string success)
        {
            Security security = new Security(password);
            string sql = $"INSERT INTO Персонал(Имя, Фамилия, Должность, Зарплата, Соль, Хеш_Пароля) " +
                $"VALUES('{name}', '{surname}', '{position}', {salary}, '{security.Salt}', " +
                $"'{security.Password}')";
            Database database = new Database();
            database.Execute(sql, _exception, success);
        }
        public void AddWare(string name, string adress, string disription, string v, string success)
        {
            try
            {
                string sql = $"INSERT INTO Склад (Название, Адресс, Описание, Вместимость) " +
                    $"VALUES('{name}', '{adress}', '{disription}', '{v}')";
                Database database = new Database();
                database.Execute(sql, _exception, success);
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены неверно", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AddProduct(string name, string category, string disription, string v, string success)
        {
            try
            {
                string sql = $"INSERT INTO Товары_Склада (Название, Категория_Товара, Описание, Объем_товара) " +
                    $"VALUES('{name}', '{category}', '{disription}', '{v}')";
                Database database = new Database();
                database.Execute(sql, _exception, success);
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены неверно", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AddVendor(string name, string adress, string phone, string success)
        {
            try
            {
                string sql = $"INSERT INTO Поставщик (Название, Адресс, Телефон) " +
                    $"VALUES('{name}', '{adress}', '{phone}')";
                Database database = new Database();
                database.Execute(sql, _exception, success);
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены неверно", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool Auth(string login, string password)
        {
            string _salt = "";
            string position = string.Join("", login.TakeWhile(char.IsLetter));
            string id = string.Join("", login.SkipWhile(char.IsLetter));
            if (position == "Администратор" || position == "Кладовщик")
            {
                // Проверяем, есть ли цифры в строке числовой части и преобразуем их в int
                int numericValue;
                bool isNumeric = int.TryParse(id, out numericValue);

                if (!isNumeric)
                {
                    System.Windows.Forms.MessageBox.Show("Не правильно введен логин или пароль", "Ошибка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
                // Выполняем проверку аутентификации через таблицу "Персонал"
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    try
                    {
                        connection.Open();
                        string queryF = "SELECT COUNT(*) FROM Персонал WHERE " +
                            "Должность = @Position AND Код_Сотрудника = @ID";
                        SqlCommand commandSalt = new SqlCommand(queryF, connection);
                        commandSalt.Parameters.AddWithValue("@Position", position);
                        commandSalt.Parameters.AddWithValue("@ID", id);
                        int countSalt = (int)commandSalt.ExecuteScalar();

                        if (countSalt > 0)
                        {
                            string querySalt = $"SELECT Соль FROM Персонал WHERE Код_Сотрудника = '{id}'";
                            SqlCommand commandHash = new SqlCommand(querySalt, connection);
                            SqlDataReader reader = commandHash.ExecuteReader();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string salt = reader.GetString(0);
                                    _salt = salt;
                                }
                            }
                            reader.Close();
                            Security security = new Security(password, _salt);
                            password = security.PasswordCheck;
                        }
                        else
                        {
                            MessageBox.Show("Неверные учетные данные.");
                            return false;
                        }
                        string query = "SELECT COUNT(*) FROM Персонал WHERE Должность = @Position " +
                        "AND Код_Сотрудника = @ID AND Хеш_Пароля = @Password";
                        SqlCommand commandAuth = new SqlCommand(query, connection);
                        commandAuth.Parameters.AddWithValue("@Position", position);
                        commandAuth.Parameters.AddWithValue("@ID", id);
                        commandAuth.Parameters.AddWithValue("@Password", password);

                        int count = (int)commandAuth.ExecuteScalar();

                        if (count > 0)
                        {
                            using (connection)
                            {
                                string queryInfo = $"SELECT Имя, Фамилия, Зарплата, Должность FROM Персонал WHERE Код_Сотрудника = '{id}' and Хеш_Пароля = '{password}'";
                                SqlCommand commandInfo = new SqlCommand(queryInfo, connection);

                                SqlDataReader reader = commandInfo.ExecuteReader();
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        string _name = reader.GetString(0);
                                        string _second = reader.GetString(1);
                                        decimal _salary = reader.GetDecimal(2);
                                        string _position = reader.GetString(3);
                                        User.Login = login;
                                        User.Name = _name;
                                        User.Surname = _second;
                                        User.Salary = _salary;
                                        User.Position = _position;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Нет данных для отображения");
                                }

                                reader.Close();
                            }
                            return true;

                        }
                        else
                        {
                            MessageBox.Show("Неверные учетные данные");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка аутентификации: " + ex.Message);
                    }
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Нет доступа", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return false;
        }
        public string Show_User_ID(string position)
        {
            try
            {
                string query = $"SELECT Код_Сотрудника FROM Персонал WHERE Должность = '{position}' " +
                    "AND Код_Сотрудника = (SELECT MAX(Код_Сотрудника) FROM Персонал " +
                    $"WHERE Должность = '{position}');";
                string userID = null;

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            userID = reader.GetInt32(0).ToString(); // Получаем ID пользователя
                        }
                        reader.Close();
                        return userID;
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Данные не найдены.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены неверно", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public void return_ID_ComboBox(string id, string table, ComboBox comboBox)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = $"SELECT {id} FROM {table}";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    comboBox.Items.Clear();

                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader[id].ToString());
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка запроса", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void delete_ID(string id, string id_delete, string table)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = $"DELETE FROM {table} WHERE {id} = {id_delete}";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка запроса", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void update_table(string table_name, string id_update_name, string id_update, string field1_name,
            string field1)
        {
            try
            {
                string updateQuery = $"UPDATE {table_name} SET {field1_name} = '{field1}' " +
                    $"WHERE {id_update_name} = '{id_update}'";
                Execute(updateQuery, _exception);
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены неверно", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string getNameStuff(string id)
        {
            try
            {
                string query = $"SELECT Имя, Фамилия FROM Персонал WHERE Код_Сотрудника = {id}";
                string userName = null;
                string userSur = null;

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            userName = reader.GetString(0).ToString();
                            userSur = reader.GetString(1).ToString();
                        }
                        reader.Close();
                        return userName + "  " + userSur;
                    }
                    else
                    {
                        reader.Close();
                        return null;
                    }
                }
            }
            catch (Exception)
            {

            }
            return null;
        }


        public string getNameVendor(string id)
        {
            try
            {
                string query = $"SELECT Название FROM Поставщик WHERE Код_Поставщика = {id}";
                string userName = null;

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            userName = reader.GetString(0).ToString();
                        }
                        reader.Close();
                        return userName;
                    }
                    else
                    {
                        reader.Close();
                        return null;
                    }
                }
            }
            catch (Exception)
            {

            }
            return null;
        }
    

    public string getNameWrs(string id)
    {
        try
        {
            string query = $"SELECT Название FROM Склад WHERE Номер_Склада = {id}";
            string userName = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        userName = reader.GetString(0).ToString();
                    }
                    reader.Close();
                    return userName;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
        }
        catch (Exception)
        {

        }
        return null;
    }
    }
}


