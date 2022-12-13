using ClassLibraryModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDAL
{
    public class CompanyMemberRegDAL
    {
        public static int SaveCompanyMember(CompanyMemberRegModel cmr)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_AddCompanyMember", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Tour_Member_ID", cmr.Tour_Member_ID);
            cmd.Parameters.AddWithValue("@Company_Member_Firstname", cmr.Company_Member_Firstname);
            cmd.Parameters.AddWithValue("@Company_Member_Lastname", cmr.Company_Member_Lastname);
            cmd.Parameters.AddWithValue("@Company_Member_DOB", cmr.Company_Member_DOB);
            cmd.Parameters.AddWithValue("@Company_Member_Gender", cmr.Company_Member_Gender);
            cmd.Parameters.AddWithValue("@Company_Member_role", cmr.Company_Member_role);
            cmd.Parameters.AddWithValue("@Company_Member_CNIC", cmr.Company_Member_CNIC);
            cmd.Parameters.AddWithValue("@Company_Member_Whatsapp", cmr.Company_Member_Whatsapp);
            cmd.Parameters.AddWithValue("@Company_Member_Mobile", cmr.Company_Member_Mobile);
            cmd.Parameters.AddWithValue("@City_ID", cmr.City_ID);
            cmd.Parameters.AddWithValue("@Company_Member_Sector", cmr.Company_Member_Sector);
            cmd.Parameters.AddWithValue("@Company_Member_registration_datetime", cmr.Company_Member_registration_datetime);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public static List<CompanyMemberRegModel> GetCompanyMembers()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetCompanyMembers", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CompanyMemberRegModel> CompanyMembersList = new List<CompanyMemberRegModel>();
            while (reader.Read())
            {
                CompanyMemberRegModel companyMembers = new CompanyMemberRegModel();
                companyMembers.Company_Member_ID = int.Parse(reader["Company_Member_ID"].ToString());
                companyMembers.Tour_Member_ID = int.Parse(reader["Tour_Member_ID"].ToString());
                companyMembers.Company_Member_Firstname = reader["Company_Member_Firstname"].ToString();
                companyMembers.Company_Member_Lastname = reader["Company_Member_Lastname"].ToString();
                companyMembers.Company_Member_DOB = int.Parse(reader["Company_Member_DOB"].ToString());
                companyMembers.Company_Member_Gender = reader["Company_Member_Gender"].ToString();
                companyMembers.Company_Member_role = reader["Company_Member_role"].ToString();
                companyMembers.Company_Member_CNIC = int.Parse(reader["Company_Member_CNIC"].ToString());
                companyMembers.Company_Member_Whatsapp = int.Parse(reader["Company_Member_Whatsapp"].ToString());
                companyMembers.Company_Member_Mobile = int.Parse(reader["Company_Member_Mobile"].ToString());
                companyMembers.City_ID = int.Parse(reader["City_ID"].ToString());
                companyMembers.Company_Member_Sector = reader["Company_Member_Sector"].ToString();
                companyMembers.Company_Member_registration_datetime = DateTime.Parse(reader["Company_Member_registration_datetime"].ToString());
                CompanyMembersList.Add(companyMembers);
            }
            con.Close();
            return CompanyMembersList;
        }
        public static List<CompanyMemberRegModel> GetCompanyMember(int id)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetCompanyMemberByID", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Tour_Member_ID", id);
            SqlDataReader reader = cmd.ExecuteReader();
            List<CompanyMemberRegModel> CompanyMembersList = new List<CompanyMemberRegModel>();
            while (reader.Read())
            {
                CompanyMemberRegModel companyMembers = new CompanyMemberRegModel();
                companyMembers.Company_Member_ID = int.Parse(reader["Company_Member_ID"].ToString());
                companyMembers.Tour_Member_ID = int.Parse(reader["Tour_Member_ID"].ToString());
                companyMembers.Company_Member_Firstname = reader["Company_Member_Firstname"].ToString();
                companyMembers.Company_Member_Lastname = reader["Company_Member_Lastname"].ToString();
                companyMembers.Company_Member_DOB = int.Parse(reader["Company_Member_DOB"].ToString());
                companyMembers.Company_Member_Gender = reader["Company_Member_Gender"].ToString();
                companyMembers.Company_Member_role = reader["Company_Member_role"].ToString();
                companyMembers.Company_Member_CNIC = int.Parse(reader["Company_Member_CNIC"].ToString());
                companyMembers.Company_Member_Whatsapp = int.Parse(reader["Company_Member_Whatsapp"].ToString());
                companyMembers.Company_Member_Mobile = int.Parse(reader["Company_Member_Mobile"].ToString());
                companyMembers.City_ID = int.Parse(reader["City_ID"].ToString());
                companyMembers.Company_Member_Sector = reader["Company_Member_Sector"].ToString();
                companyMembers.Company_Member_registration_datetime = DateTime.Parse(reader["Company_Member_registration_datetime"].ToString());
                CompanyMembersList.Add(companyMembers);
            }
            con.Close();
            return CompanyMembersList;
        }
        public static int DeleteCompanyMember(int Company_Member_ID)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_DeleteCompanyMember", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Company_Member_ID", Company_Member_ID);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
    
}
