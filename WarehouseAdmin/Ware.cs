using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAdmin
{
    public class Ware
    {
        private string _connectionString = Properties.Settings.Default.connection;
        public decimal V(int id)
        {
            string query = $@"
           SELECT 
    Склад.Вместимость - SUM(Товары_Склада.Объем_товара*Приемка_Товара.Количество) AS Оставшееся_Место
FROM 
    Склад, Приемка_Товара,Товары_Склада,Накладная
Where
	Товары_Склада.Код_Товара_На_Складе = Приемка_Товара.Код_Товара
AND
	Накладная.Номер_Накладной = Приемка_Товара.Номер_Накладной
AND 
	Склад.Номер_Склада = Накладная.Номер_Склада
AND
	Склад.Номер_Склада = {id}
GROUP BY 
    Склад.Вместимость;
";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        decimal оставшеесяМесто = reader.GetDecimal(0); // Оставшееся место

                        return оставшеесяМесто;
                    }
                }
                else
                {
                    MessageBox.Show("Нет данных для отображения", "Результат запроса", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                reader.Close();
                return 0;
            }
        }
        public List<int> GetAllStorageIds()
        {
            List<int> storageIds = new List<int>();

            string query = "SELECT Номер_Склада FROM Склад"; // Запрос для получения номеров складов

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int storageId = reader.GetInt32(0);
                    storageIds.Add(storageId);
                }

                reader.Close();
            }

            return storageIds;
        }
    }
}
