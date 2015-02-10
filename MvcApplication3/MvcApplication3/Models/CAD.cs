using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;
namespace MvcApplication3.Models
{
    public class CAD
    {// CAD 192.168.0.10:1521/pharm
        // login :oranet mdp:123
        private static string GetConnectionString()
        {
            String connString = "host= 192.168.0.10:1521;database=pharm;uid=oranet;pwd=123";
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
                string sql = "SELECT * FROM USER";
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