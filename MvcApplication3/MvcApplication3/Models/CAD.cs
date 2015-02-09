using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;
namespace MvcApplication3.Models
{
    public class CAD
    {
        private static string GetConnectionString()
        {
            String connString = "host= serverName;database=myDatabase;uid=userName;pwd=passWord";
            return connString;
        }

        private static void ConnectingToOracle()
        {
            string connectionString = GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                Console.WriteLine("State: {0}", connection.State);
                Console.WriteLine("ConnectionString: {0}",
                                  connection.ConnectionString);

                OracleCommand command = connection.CreateCommand();
                string sql = "SELECT * FROM myTableName";
                command.CommandText = sql;

                OracleDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string myField = (string)reader["MYFIELD"];
                    Console.WriteLine(myField);
                }
            }
        }
    }
}