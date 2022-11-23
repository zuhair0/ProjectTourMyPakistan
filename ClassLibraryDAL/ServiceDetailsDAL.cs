using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryModel;

namespace ClassLibraryDAL
{
    public class ServiceDetailsDAL
    {
        public static int SaveServiceDetails(ServiceDetailsModel sdm )
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_SaveServiceDetails", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Sub_Cat_ID",sdm.Sub_Cat_ID);
            cmd.Parameters.AddWithValue("@Cat_ID",sdm.Cat_ID);
            cmd.Parameters.AddWithValue("@SD_Title",sdm.SD_Title);
            cmd.Parameters.AddWithValue("@SD_Price",sdm.SD_Price);
            cmd.Parameters.AddWithValue("@SD_Quantity",sdm.SD_Quantity);
            cmd.Parameters.AddWithValue("@SD_Unit",sdm.SD_Unit);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public static List<ServiceDetailsModel> GetServiceDetails()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetServiceDetails", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<ServiceDetailsModel> serviceDetailsList = new List<ServiceDetailsModel>();
            while (sdr.Read())
            {
                ServiceDetailsModel serviceDetailsModel = new ServiceDetailsModel();
                serviceDetailsModel.SD_ID = int.Parse(sdr["SD_ID"].ToString());
                serviceDetailsModel.Sub_Cat_ID = int.Parse(sdr["Sub_Cat_ID"].ToString());
                serviceDetailsModel.Cat_ID = int.Parse(sdr["Cat_ID"].ToString());
                serviceDetailsModel.SD_Title = sdr["SD_Title"].ToString();
                serviceDetailsModel.SD_Price = int.Parse(sdr["SD_Price"].ToString());
                serviceDetailsModel.SD_Quantity = int.Parse(sdr["SD_Quantity"].ToString());
                serviceDetailsModel.SD_Unit = int.Parse(sdr["SD_Unit"].ToString());
                serviceDetailsList.Add(serviceDetailsModel);
            }
            con.Close();
            return serviceDetailsList;
        }
        public static int DeleteServiceSubCategory(int SD_ID)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_DeleteServiceDetails", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SD_ID", SD_ID);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
