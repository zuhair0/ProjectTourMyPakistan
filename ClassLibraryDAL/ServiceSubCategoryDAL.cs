using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryModel;

namespace ClassLibraryDAL
{
    public class ServiceSubCategoryDAL
    {
        public static int SaveServiceSubCategory(ServiceSubCategoryModel sscm)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_SaveServiceSubCategory", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cat_ID", sscm.Cat_ID);
            cmd.Parameters.AddWithValue("@Sub_Cat_Title", sscm.Sub_Cat_Title);
            int i=cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public static List<ServiceSubCategoryModel> GetServiceSubCategories()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetServiceSubCategory", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<ServiceSubCategoryModel> serviceSubCategoriesList = new List<ServiceSubCategoryModel>();
            while (sdr.Read())
            {
                ServiceSubCategoryModel serviceSubCategoryModel = new ServiceSubCategoryModel();
                serviceSubCategoryModel.Sub_cat_ID = int.Parse(sdr["Sub_cat_ID"].ToString());
                serviceSubCategoryModel.Cat_ID = int.Parse(sdr["Cat_ID"].ToString());
                serviceSubCategoryModel.Sub_Cat_Title = sdr["Sub_Cat_Title"].ToString();
                serviceSubCategoriesList.Add(serviceSubCategoryModel);            
            }
            con.Close();
            return serviceSubCategoriesList;
        }
        public static int DeleteServiceSubCategory(int Cat_ID)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_DeleteServiceSubCategory", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Sub_cat_ID", Cat_ID);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
