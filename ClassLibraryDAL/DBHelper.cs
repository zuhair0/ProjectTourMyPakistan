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
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-ISNN91B\\SQL2019;Initial Catalog=TOURISM;Integrated Security=True");
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-NTASNM1\\DELL;Initial Catalog=Tourism;Integrated Security=True");
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-PO81H2P\\DELL1;Initial Catalog=Tourism;Integrated Security=True");
            return con;
        }
    }
}
