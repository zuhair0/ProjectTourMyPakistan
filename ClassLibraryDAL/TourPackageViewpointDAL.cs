using ClassLibraryModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDAL
{
    public class TourPackageViewpointDAL
    {
        public static int SaveTourPackageViewpoint(TourPackageViewpointModel tcvm)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_SaveTourPackageViewpoint", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Vp_id", tcvm.Vp_id);
            cmd.Parameters.AddWithValue("@Field",tcvm.Field);
            cmd.Parameters.AddWithValue("@PKG_Id", tcvm.PKG_Id);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public static List<TourPackageViewpointModel> GetTourPackageViewpoints()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetTourPackageViewpoint", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            List<TourPackageViewpointModel> TourPackageviewpointlist = new List<TourPackageViewpointModel>();
            while (reader.Read())
            {
                TourPackageViewpointModel viewpointModel = new TourPackageViewpointModel();
                viewpointModel.Tour_PKG_View_ID = int.Parse(reader["Tour_PKG_View_ID"].ToString());
                viewpointModel.Vp_id = int.Parse(reader["Vp_id"].ToString());
                viewpointModel.PKG_Id = int.Parse(reader["PKG_Id"].ToString());
                viewpointModel.Field = reader["Field"].ToString();
                TourPackageviewpointlist.Add(viewpointModel);
            }
            con.Close();
            return TourPackageviewpointlist;
        }
        public static List<TourPackageViewpointModel> GetTourPackageViewpoint(int id)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetTourPackageViewpointByTPid", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PKG_Id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            List<TourPackageViewpointModel> TourPackageviewpointlist = new List<TourPackageViewpointModel>();
            while (reader.Read())
            {
                TourPackageViewpointModel viewpointModel = new TourPackageViewpointModel();
                viewpointModel.Tour_PKG_View_ID = int.Parse(reader["Tour_PKG_View_ID"].ToString());
                viewpointModel.Vp_id = int.Parse(reader["Vp_id"].ToString());
                viewpointModel.PKG_Id = int.Parse(reader["PKG_Id"].ToString());
                viewpointModel.Field = reader["Field"].ToString();
                TourPackageviewpointlist.Add(viewpointModel);
            }
            con.Close();
            return TourPackageviewpointlist;
        }

        public static int DeleteTourPackageViewpoint(int Tour_PKG_View_ID)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_DeleteTourPackageViewpoint", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Tour_PKG_View_ID", Tour_PKG_View_ID);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}   