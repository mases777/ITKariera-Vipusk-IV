using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CRUDWithoutORM.Data
{
    public static class DataBase
    {
        private static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database=shop4;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
