﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryModel;
namespace ClassLibraryDAL
{
    public class TourCompanyRegDAL
    {
        public static int SaveTourCompanyReg(TourCompanyRegModel tcrm)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_SaveTourCompanyReg", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Tour_guide_id",tcrm.Tour_guide_id );
            cmd.Parameters.AddWithValue("@Company_name", tcrm.Company_name);
            cmd.Parameters.AddWithValue("@Company_sector", tcrm.Company_sector);
            cmd.Parameters.AddWithValue("@City_id", tcrm.City_id);
            cmd.Parameters.AddWithValue("@Company_longitude_latitude",tcrm.Company_longitude_latitude );
            cmd.Parameters.AddWithValue("@Company_website",tcrm.Company_website );
            cmd.Parameters.AddWithValue("@Company_Facebook", tcrm.Company_Facebook);
            cmd.Parameters.AddWithValue("@Company_Instagram", tcrm.Company_Instagram);
            cmd.Parameters.AddWithValue("@Company_contact1", tcrm.Company_contact1);
            cmd.Parameters.AddWithValue("@Company_contact2", tcrm.Company_contact2);
            cmd.Parameters.AddWithValue("@Company_Whatsapp", tcrm.Company_Whatsapp);
            cmd.Parameters.AddWithValue("@Company_Landline", tcrm.Company_Landline);
            cmd.Parameters.AddWithValue("@Tour_Company_Registration_date_time", tcrm.Tour_Company_Registration_date_time);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public static List<TourCompanyRegModel> GetTourCompanyRegistrations()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetTourCompanyReg", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            List<TourCompanyRegModel> tourCompaniesList = new List<TourCompanyRegModel>();
            while (reader.Read())
            {
                TourCompanyRegModel tourCompany = new TourCompanyRegModel();
                tourCompany.Company_ID = int.Parse(reader["Company_ID"].ToString());
                tourCompany.Tour_guide_id = int.Parse(reader["Tour_guide_id"].ToString());
                tourCompany.Company_name = reader["Company_name"].ToString();
                tourCompany.Company_sector = reader["Company_sector"].ToString();
                tourCompany.City_id = int.Parse(reader["City_id"].ToString());
                tourCompany.Company_longitude_latitude = int.Parse(reader["Company_longitude_latitude"].ToString());
                tourCompany.Company_website = reader["Company_website"].ToString();
                tourCompany.Company_Facebook = reader["Company_Facebook"].ToString();
                tourCompany.Company_Instagram = reader["Company_Instagram"].ToString();
                tourCompany.Company_contact1 = int.Parse(reader["Company_contact1"].ToString());
                tourCompany.Company_contact2 = int.Parse(reader["Company_contact2"].ToString());
                tourCompany.Company_Whatsapp = int.Parse(reader["Company_Whatsapp"].ToString());
                tourCompany.Company_Landline = int.Parse(reader["Company_Landline"].ToString());
                //tourCompany.Tour_Company_Registration_date_time = reader["Tour_Company_Registration_date_time"].ToString();
                tourCompaniesList.Add(tourCompany);
            }
            con.Close();
            return tourCompaniesList;
        }
        public static List<TourCompanyRegModel> GetTourCompanyRegistration(int id)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetCompanyByTourID", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Tour_guide_id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            List<TourCompanyRegModel> tourCompaniesList = new List<TourCompanyRegModel>();
            while (reader.Read())
            {
                TourCompanyRegModel tourCompany = new TourCompanyRegModel();
                tourCompany.Company_ID = int.Parse(reader["Company_ID"].ToString());
                tourCompany.Tour_guide_id = int.Parse(reader["Tour_guide_id"].ToString());
                tourCompany.Company_name = reader["Company_name"].ToString();
                tourCompany.Company_sector = reader["Company_sector"].ToString();
                tourCompany.City_id = int.Parse(reader["City_id"].ToString());
                tourCompany.Company_longitude_latitude = int.Parse(reader["Company_longitude_latitude"].ToString());
                tourCompany.Company_website = reader["Company_website"].ToString();
                tourCompany.Company_Facebook = reader["Company_Facebook"].ToString();
                tourCompany.Company_Instagram = reader["Company_Instagram"].ToString();
                tourCompany.Company_contact1 = int.Parse(reader["Company_contact1"].ToString());
                tourCompany.Company_contact2 = int.Parse(reader["Company_contact2"].ToString());
                tourCompany.Company_Whatsapp = int.Parse(reader["Company_Whatsapp"].ToString());
                tourCompany.Company_Landline = int.Parse(reader["Company_Landline"].ToString());
                //tourCompany.Tour_Company_Registration_date_time = reader["Tour_Company_Registration_date_time"].ToString();
                tourCompaniesList.Add(tourCompany);
            }
            con.Close();
            return tourCompaniesList;
        }
        public static int DeleteTourGuide(int Company_ID)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_DeleteTourCompany", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Company_ID", Company_ID);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
