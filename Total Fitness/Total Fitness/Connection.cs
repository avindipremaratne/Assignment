using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;  
namespace Total_Fitness
{
    class Connection
    {
        public SqlConnection Conn;
        //public static string username;
        public void DBConn()
        {
            Conn = new SqlConnection(@"Data Source=AVINDI-PC\SQLEXPRESS;Initial Catalog=Total Fitness; Integrated Security=SSPI");
            
        }
    }
}
