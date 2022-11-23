using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClassLibraryDAL
{
    public class DBHelper
    {
        public static SqlConnection GetConnection()
        {//hjj
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-PO81H2P\\DELL1;Initial Catalog=Tourism;Integrated Security=True");
            return con;
        }
    }
}
