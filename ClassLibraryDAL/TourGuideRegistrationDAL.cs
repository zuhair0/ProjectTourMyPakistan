using ClassLibraryModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDAL
{
    public class TourGuideRegistrationDAL
    {
        public static int SaveTourGuideRegistration(TourGuideRegistrationModel tgrm)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_SaveTourGuideReg", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
           // cmd.Parameters.AddWithValue("@TG_id",tgrm.TG_id);
            cmd.Parameters.AddWithValue("@TG_name",tgrm.TG_name);
            cmd.Parameters.AddWithValue("@TG_cnic",tgrm.TG_cnic);
            cmd.Parameters.AddWithValue("@TG_DOB", tgrm.TG_DOB);
            cmd.Parameters.AddWithValue("@TG_Gender",tgrm.TG_Gender);
            cmd.Parameters.AddWithValue("@TG_Mobile",tgrm.TG_Mobile);
            cmd.Parameters.AddWithValue("@TG_Whatsapp",tgrm.TG_Whatsapp);
            cmd.Parameters.AddWithValue("@TG_Landline",tgrm.TG_Landline);
            cmd.Parameters.AddWithValue("@TG_city", tgrm.TG_city);
            cmd.Parameters.AddWithValue("@TG_Sector",tgrm.TG_Sector);
            cmd.Parameters.AddWithValue("@TG_Longitude",tgrm.TG_Longitude);
            cmd.Parameters.AddWithValue("@TG_latitude",tgrm.TG_latitude);
            cmd.Parameters.AddWithValue("@TG_registration_date",tgrm.TG_registration_date);
            cmd.Parameters.AddWithValue("@TG_registration_time",tgrm.TG_registration_time);
            cmd.Parameters.AddWithValue("@idd", tgrm.idd);
            // cmd.Parameters.AddWithValue("@TG_Registration_status",tgrm.TG_Registration_status);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public static List<TourGuideRegistrationModel> GetTourGuideRegistrations()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetTourGuides", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            List<TourGuideRegistrationModel> tourGuidesList = new List<TourGuideRegistrationModel>();
            while (reader.Read())
            {
                TourGuideRegistrationModel tourGuide = new TourGuideRegistrationModel();
                tourGuide.TG_id = int.Parse(reader["TG_id"].ToString());
                tourGuide.TG_name = reader["TG_name"].ToString();
                tourGuide.TG_cnic = int.Parse(reader["TG_cnic"].ToString());
                tourGuide.TG_DOB = reader["TG_DOB"].ToString();
                tourGuide.TG_Gender = reader["TG_Gender"].ToString();
                tourGuide.TG_Mobile = int.Parse(reader["TG_Mobile"].ToString());
                tourGuide.TG_Whatsapp = int.Parse(reader["TG_Whatsapp"].ToString());
                tourGuide.TG_Landline = int.Parse(reader["TG_Landline"].ToString());
                tourGuide.TG_city = reader["TG_city"].ToString();
                tourGuide.TG_Sector = reader["TG_Sector"].ToString();
                tourGuide.TG_Longitude = float.Parse(reader["TG_Longitude"].ToString());
                tourGuide.TG_latitude = float.Parse(reader["TG_latitude"].ToString());
                tourGuide.idd = reader["idd"].ToString();
                //tourGuide.TG_registration_date = reader["TG_registration_date"].ToString();
                //tourGuide.TG_registration_time = reader["TG_registration_time"].ToString();
                //tourGuide.TG_Registration_status = reader["TG_Registration_status"].ToString();
                tourGuidesList.Add(tourGuide);
            }
            con.Close();
            return tourGuidesList;
        }
        public static List<TourGuideRegistrationModel> GetTourGuideRegistration(string id)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetTourGuidesByIdd", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idd",id);
            SqlDataReader reader = cmd.ExecuteReader();
            List<TourGuideRegistrationModel> tourGuidesList = new List<TourGuideRegistrationModel>();
            while (reader.Read())
            {
                TourGuideRegistrationModel tourGuide = new TourGuideRegistrationModel();
                tourGuide.TG_id = int.Parse(reader["TG_id"].ToString());
                tourGuide.TG_name = reader["TG_name"].ToString();
                tourGuide.TG_cnic = int.Parse(reader["TG_cnic"].ToString());
                tourGuide.TG_DOB = reader["TG_DOB"].ToString();
                tourGuide.TG_Gender = reader["TG_Gender"].ToString();
                tourGuide.TG_Mobile = int.Parse(reader["TG_Mobile"].ToString());
                tourGuide.TG_Whatsapp = int.Parse(reader["TG_Whatsapp"].ToString());
                tourGuide.TG_Landline = int.Parse(reader["TG_Landline"].ToString());
                tourGuide.TG_city = reader["TG_city"].ToString();
                tourGuide.TG_Sector = reader["TG_Sector"].ToString();
                tourGuide.TG_Longitude = float.Parse(reader["TG_Longitude"].ToString());
                tourGuide.TG_latitude = float.Parse(reader["TG_latitude"].ToString());
                tourGuide.idd = reader["idd"].ToString();
                //tourGuide.TG_registration_date = reader["TG_registration_date"].ToString();
                //tourGuide.TG_registration_time = reader["TG_registration_time"].ToString();
                //tourGuide.TG_Registration_status = reader["TG_Registration_status"].ToString();
                tourGuidesList.Add(tourGuide);
            }
            con.Close();
            return tourGuidesList;
        }
        public static int DeleteTourGuide(int TG_id)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_DeleteTourGuide", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TG_id", TG_id);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
