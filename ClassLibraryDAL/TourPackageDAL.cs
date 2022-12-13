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
        public static List<TourPackageModel> GetPackages()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetPackages", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<TourPackageModel> TourPackageList = new List<TourPackageModel>();
            while (sdr.Read())
            {
                TourPackageModel tourpm = new TourPackageModel();
                tourpm.PKG_Id = int.Parse(sdr["PKG_Id"].ToString());
                tourpm.Tour_Guide_ID = int.Parse(sdr["Tour_Guide_ID"].ToString());
                tourpm.PKG_Title = sdr["PKG_Title"].ToString();
                tourpm.PKG_Duration = sdr["PKG_Duration"].ToString();
                tourpm.PKG_Pricing = sdr["PKG_Pricing"].ToString();
                tourpm.PKG_From_City = sdr["PKG_From_City"].ToString();
                tourpm.PKG_To_City = sdr["PKG_To_City"].ToString();
                TourPackageList.Add(tourpm);
            }
            con.Close();
            return TourPackageList;
        }
        public static List<TourPackageModel> GetPackage(int id)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetTourPackageByCompID", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Tour_Guide_ID", id);
            SqlDataReader sdr = cmd.ExecuteReader();
            List<TourPackageModel> TourPackageList = new List<TourPackageModel>();
            while (sdr.Read())
            {
                TourPackageModel tourpm = new TourPackageModel();
                tourpm.PKG_Id = int.Parse(sdr["PKG_Id"].ToString());
                tourpm.Tour_Guide_ID = int.Parse(sdr["Tour_Guide_ID"].ToString());
                tourpm.PKG_Title = sdr["PKG_Title"].ToString();
                tourpm.PKG_Duration = sdr["PKG_Duration"].ToString();
                tourpm.PKG_Pricing = sdr["PKG_Pricing"].ToString();
                tourpm.PKG_From_City = sdr["PKG_From_City"].ToString();
                tourpm.PKG_To_City = sdr["PKG_To_City"].ToString();
                TourPackageList.Add(tourpm);
            }
            con.Close();
            return TourPackageList;
        }
        public static int DeleteTourPackage(int PKG_Id)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_DeletePackage", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PKG_Id", PKG_Id);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
