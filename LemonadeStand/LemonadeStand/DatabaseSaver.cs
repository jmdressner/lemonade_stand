using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LemonadeStand
{
    public class DatabaseSaver
    {
        SqlConnection connection;

        public DatabaseSaver()
        {
            connection = new SqlConnection("Server=WINDOWS-M4TNQ6I;Database=firstDB;Integrated Security=true");
        }

        public void Save(string name, double sumProfit, double sumLoss)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"INSERT INTO Lemonade_Stand VALUES ('{name}', '{sumProfit}', '{sumLoss}')", connection);
                command.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("Game Saved");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
