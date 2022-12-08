using ClassLibraryModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDAL
{
    public class TourPackageServicesDAL
    {
        public static int SaveTPServices(TourPackageServicesModel tpsm)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_SaveTourPkgServices", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Company_Service_ID", tpsm.Company_Service_ID);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public static List<TourPackageServicesModel> GetTourPackageServices()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetTourPkgServices", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<TourPackageServicesModel> TourPKGServices = new List<TourPackageServicesModel>();
            while (sdr.Read())
            {
                TourPackageServicesModel tps = new TourPackageServicesModel();
                tps.Company_Service_ID = int.Parse(sdr["Company_Service_ID"].ToString());
                TourPKGServices.Add(tps);
            }
            con.Close();
            return TourPKGServices;
        }
        public static int DeleteTourPkgServices(int Company_Service_ID)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_DeleteTourPkgService", con);
            cmd.Parameters.AddWithValue("@Company_Service_ID", con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
    
}
