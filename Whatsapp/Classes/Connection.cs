using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Whatsapp
{
    class Connection
    {
        public static SqlConnection conn = new SqlConnection("Data source = .\\sqlexpress; initial catalog = db_whatsapp; integrated security = true;");
        public static SqlCommand cmd = new SqlCommand() { Connection = conn };

        public static void openCon()
        {
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();
        }

        public static void closeCon()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
                conn.Close();
        }

        public static int sendQuery(string query)
        {
            int rows = 0;
            cmd.CommandText = query;

            openCon();
            rows = cmd.ExecuteNonQuery();
            closeCon();

            return rows;
        }

        public static SqlDataReader getReader(string query)
        {
            cmd.CommandText = query;

            openCon();
            return cmd.ExecuteReader();
        }

        public static object getScalar(string query)
        {
            cmd.CommandText = query;

            openCon();
            return cmd.ExecuteScalar();
        }
    }
}
