using ClassLibraryModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryModel;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Emit;

namespace ClassLibraryDAL
{
    public class ViewPointImageDAL
    {
        public static int SaveViewPointImage(ViewPointImageModel vpim)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_ViewPointImage", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@VP_id", vpim.VP_id);
            cmd.Parameters.AddWithValue("@VP_image_url", vpim.VP_image_url);
            cmd.Parameters.AddWithValue("@VP_details_Eng", vpim.Vp_detail_Eng);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public static List<ViewPointImageModel> GetViewpointsImage()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetViewPointImage", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<ViewPointImageModel> viewPointsImageList = new List<ViewPointImageModel>();
            while (sdr.Read())
            {
                ViewPointImageModel viewPointImage = new ViewPointImageModel();
                int a;
              
                if (Int32.TryParse(sdr["VP_id"].ToString(), out a))
                {
                    viewPointImage.VP_id = a;
                }
                viewPointImage.VP_image_url = sdr["VP_image_url"].ToString();
                viewPointImage.Vp_detail_Eng = sdr["Vp_detail_Eng"].ToString();
                viewPointsImageList.Add(viewPointImage);
            }
            con.Close();
            return viewPointsImageList;
        }
        public static int DeleteViewPointImage(int Vp_id)
        {
            SqlConnection con=DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_DeleteViewPointImage", con);
            cmd.CommandType=System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@VP_id", Vp_id);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }
    }
}
