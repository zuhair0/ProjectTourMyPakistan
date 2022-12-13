using ClassLibraryModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDAL
{
    public class CompanyPortfolioDAL
    {
        public static int SaveCompanyPortfolio(CompanyPortfolioModel cpm)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_SaveCompanyPortfolio", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Company_Id", cpm.Company_Id);
            cmd.Parameters.AddWithValue("@Portfolio_details",cpm.Portfolio_details);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public static List<CompanyPortfolioModel> GetCompanyPortfolio()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetCompanyPortfolio", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CompanyPortfolioModel> companyPortfolioList = new List<CompanyPortfolioModel>();
            while (reader.Read())
            {
                CompanyPortfolioModel portfolioModel = new CompanyPortfolioModel();
                portfolioModel.Portfolio_id = int.Parse(reader["Portfolio_id"].ToString());
                portfolioModel.Company_Id = int.Parse(reader["Company_Id"].ToString());
                portfolioModel.Portfolio_details = reader["Portfolio_details"].ToString();
                companyPortfolioList.Add(portfolioModel);
            }
            con.Close();
            return companyPortfolioList;
        }
        public static List<CompanyPortfolioModel> GetCompanyPortfolios(int id)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetCompanyPortfolioByCompID", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Company_Id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            List<CompanyPortfolioModel> companyPortfolioList = new List<CompanyPortfolioModel>();
            while (reader.Read())
            {
                CompanyPortfolioModel portfolioModel = new CompanyPortfolioModel();
                portfolioModel.Portfolio_id = int.Parse(reader["Portfolio_id"].ToString());
                portfolioModel.Company_Id = int.Parse(reader["Company_Id"].ToString());
                portfolioModel.Portfolio_details = reader["Portfolio_details"].ToString();
                companyPortfolioList.Add(portfolioModel);
            }
            con.Close();
            return companyPortfolioList;
        }
        public static int DeleteCompanyPortfolio(int Portfolio_id)
        { 
                SqlConnection con = DBHelper.GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("Sp_DeleteCompanyPortfolio", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Portfolio_id", Portfolio_id);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                return i;
        }
    }
}
