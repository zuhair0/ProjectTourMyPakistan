using ClassLibraryModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryModel;

namespace ClassLibraryDAL
{
    public class ServiceCateoryDAL
    {
        public static int SaveServiceCategory(ServiceCategoryModel scm)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_AddServiceCtegory", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cat_Type", scm.Cat_Type);
            cmd.Parameters.AddWithValue("@Cat_Title", scm.Cat_Title);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public static List<ServiceCategoryModel> GetServiceCategories()
        {
            SqlConnection con= DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetServiceCategories", con);
            cmd.CommandType=System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            List<ServiceCategoryModel> serviceCategoriesList = new List<ServiceCategoryModel>();
            while (reader.Read())
            {
                ServiceCategoryModel serviceCategory = new ServiceCategoryModel();

                serviceCategory.Cat_ID = int.Parse(reader["Cat_ID"].ToString());
                serviceCategory.Cat_Type = reader["Cat_Type"].ToString();
                serviceCategory.Cat_Title = reader["Cat_Title"].ToString();
                serviceCategoriesList.Add(serviceCategory);
            }
            con.Close();
            return serviceCategoriesList;
        }
        public static int DeleteServiceCategory(int Cat_ID)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_DeleteServiceCategory", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cat_ID", Cat_ID);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
