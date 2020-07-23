using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace WMS_DataAccess.Colin_DataAccess
{
   public abstract class AbstrtionDAL
    {
        private static string coon = "Data Source=192.168.43.236;Initial Catalog=WMSDB;User ID=sa;password=1234";

        public static IDbConnection GetSql()
        {
            IDbConnection con = new SqlConnection(coon);
            if (con.State != ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
    }
}
