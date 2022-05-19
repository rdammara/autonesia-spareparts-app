using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AutonesiaApp
{
    internal class Connections
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source = DESKTOP-HIMC6KT\\SQLEXPRESS; initial catalog = db_Autonesia; integrated security = true";
            return Conn;
        }
    }
}
