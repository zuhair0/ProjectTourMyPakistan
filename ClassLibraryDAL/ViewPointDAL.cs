using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryModel;
namespace ClassLibraryDAL
{
    public class ViewPointDAL
    {
        public static int SaveViewPoint(ViewPointModel vpm)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_ViewPoint", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@city_id",vpm.City_id);
            cmd.Parameters.AddWithValue("@vp_name",vpm.VP_Name);
            cmd.Parameters.AddWithValue("@vp_detail_eng",vpm.Vp_detail_Eng);
            cmd.Parameters.AddWithValue("@vp_detail_urdu",vpm.Vp_detail_Urdu);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
