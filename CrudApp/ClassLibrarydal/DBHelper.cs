using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClassLibrarydal
{
    public class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=MUSTAFA\\MSSQLSERVER01;Initial Catalog=Students;Integrated Security=True");
            return con;
        }
    }
}
