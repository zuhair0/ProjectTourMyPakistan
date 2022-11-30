﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryModel;
namespace ClassLibraryDAL
{
    public class TourCompanyServiceDAL
    {
        public static int SaveTourCompanyService(TourCompanyServiceModel tcsm)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_SaveTourCompanyService", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Category_ID",tcsm.Category_ID);
            cmd.Parameters.AddWithValue("@Sub_Category_ID",tcsm.Sub_Category_ID);
            cmd.Parameters.AddWithValue("@SD_ID",tcsm.SD_ID);
            int i=cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public static List<TourCompanyServiceModel> GetTourCompanyServices()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetTourCompanyService", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader=cmd.ExecuteReader();
            List<TourCompanyServiceModel> tourCompanyServicesList = new List<TourCompanyServiceModel>();
            while (reader.Read())
            {
                TourCompanyServiceModel tourCompany = new TourCompanyServiceModel();
                tourCompany.Company_Service_ID = int.Parse(reader["Company_Service_ID"].ToString());
                tourCompany.Category_ID = int.Parse(reader["Category_ID"].ToString());
                tourCompany.Sub_Category_ID = int.Parse(reader["Sub_Category_ID"].ToString());
                tourCompany.SD_ID = int.Parse(reader["SD_ID"].ToString());
                tourCompanyServicesList.Add(tourCompany);
            }
            con.Close();
            return tourCompanyServicesList;
        }
        public static int DeleteTourCompanyService(int Company_Service_ID)
        {
            SqlConnection con=DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_DeleteTourCompanyService", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Company_Service_ID", Company_Service_ID);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
