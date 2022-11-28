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
        //kjk
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
        public static List<ViewPointModel> GetViewpoints()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetViewPoints", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<ViewPointModel> viewPointsList = new List<ViewPointModel>();
            while (sdr.Read())
            {
                ViewPointModel viewPoint = new ViewPointModel();
                viewPoint.Vp_id= int.Parse(sdr["Vp_id"].ToString());
                viewPoint.City_id = int.Parse(sdr["City_id"].ToString());
                viewPoint.VP_Name = sdr["vp_name"].ToString();
                viewPoint.Vp_detail_Eng = sdr["vp_detail_eng"].ToString();
                viewPoint.Vp_detail_Urdu = sdr["vp_detail_urdu"].ToString();
                viewPointsList.Add(viewPoint);
            }
            con.Close();
            return viewPointsList;
        }
        public static int DeleteViewPoint(int Vp_id)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_DeleteViewPoint", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Vp_id", Vp_id);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
