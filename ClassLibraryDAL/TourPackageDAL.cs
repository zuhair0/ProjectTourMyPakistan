using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryModel;
namespace ClassLibraryDAL
{
    public class TourPackageDAL
    {
        public static int SaveTourPackage(TourPackageModel tpm)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_SaveTourPackage", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Tour_Guide_ID",tpm.Tour_Guide_ID);
            cmd.Parameters.AddWithValue("@PKG_Title",tpm.PKG_Title);
            cmd.Parameters.AddWithValue("@PKG_Duration",tpm.PKG_Duration);
            cmd.Parameters.AddWithValue("@PKG_Pricing",tpm.PKG_Pricing);
            cmd.Parameters.AddWithValue("@PKG_From_City",tpm.PKG_From_City);
            cmd.Parameters.AddWithValue("@PKG_To_City",tpm.PKG_To_City);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
