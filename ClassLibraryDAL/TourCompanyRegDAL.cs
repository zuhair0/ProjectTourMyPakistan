using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryModel
namespace ClassLibraryDAL
{
    public class TourCompanyRegDAL
    {
        public static int SaveTourCompanyReg(TourCompanyRegModel tcrm)
        {//abc
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@", );
            cmd.Parameters.AddWithValue("@", );
            cmd.Parameters.AddWithValue("@", );
            cmd.Parameters.AddWithValue("@", );
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
