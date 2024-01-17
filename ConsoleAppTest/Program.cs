using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using System.Configuration;

namespace ConsoleAppTest
{
    interface ISecurity
    {

    }

    interface IGeneratePassword
    {
        string Hash(string password);
        string GenerateSalt();
    }

    public class Security : ISecurity
    {
        private string _password;
        private string _salt;
        private IGeneratePassword _generatePassword;

        public Security(string password)
        {
            _generatePassword = new GeneratePassword();
            SetPassword(password);
        }

        public string Password
        {
            get { return _password; }
            set { SetPassword(value); }
        }

        public string Salt
        {
            get { return _salt; }
            private set { _salt = value; }
        }

        private void SetPassword(string password)
        {
            _password = password;
            Salt = _generatePassword.GenerateSalt();
            _password = _generatePassword.Hash(_password + Salt);
        }

        class GeneratePassword : IGeneratePassword
        {
            public string Hash(string password)
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);

                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] hashBytes = sha256.ComputeHash(inputBytes);
                    return Convert.ToBase64String(hashBytes);
                }
            }

            public string GenerateSalt()
            {
                int length = 50;
                const string availableChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";

                StringBuilder sb = new StringBuilder();
                Random random = new Random();

                for (int i = 0; i < length; i++)
                {
                    int index = random.Next(availableChars.Length);
                    sb.Append(availableChars[index]);
                }

                return sb.ToString();
            }
        }
    }


    internal class Program
    {
        static public string Show_User_ID(string position)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WarehouseAdmin.Properties.Settings.connection"].ConnectionString);
            try
            {
                string query = $"SELECT Код_Сотрудника FROM Персонал WHERE Должность = '{position}' " +
                    "AND Код_Сотрудника = (SELECT MAX(Код_Сотрудника) FROM Персонал " +
                    $"WHERE Должность = '{position}');";
                string userID = null;

                using (connection)
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
                        return null;
                    }
                }
            }
            catch (Exception)
            {
               
                return null;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Show_User_ID("Администратор"));
            Console.WriteLine(Show_User_ID("Кладовщик"));
            Console.WriteLine(Show_User_ID("Бухгалтер"));
        }
    }
}
