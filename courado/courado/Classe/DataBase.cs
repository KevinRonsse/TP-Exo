using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courado.Classe
{
    public class DataBase
    {
        private static string connectionString = @"Data Source=(LocalDb)\CoursDotNet;Integrated Security = True"; 


        public static SqlConnection Connection
        {
            get => new SqlConnection(connectionString);
        }
    }
}
