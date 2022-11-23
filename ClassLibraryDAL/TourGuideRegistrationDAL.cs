using ClassLibraryModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            //cmd.Parameters.AddWithValue("@TG_id",tgrm.TG_id);
            cmd.Parameters.AddWithValue("@TG_name",tgrm.TG_name);
            cmd.Parameters.AddWithValue("@TG_cnic",tgrm.TG_cnic);
            cmd.Parameters.AddWithValue("@TG_DOB", tgrm.TG_DOB);
            cmd.Parameters.AddWithValue("@TG_Gender",tgrm.TG_Gender);
            cmd.Parameters.AddWithValue("@TG_Mobile",tgrm.TG_Mobile);
            cmd.Parameters.AddWithValue("@TG_Whatsapp",tgrm.TG_Whatsapp);
            cmd.Parameters.AddWithValue("@TG_Landline",tgrm.TG_Landline);
            cmd.Parameters.AddWithValue("@TG_city",tgrm.TG_city);
            cmd.Parameters.AddWithValue("@TG_Sector",tgrm.TG_Sector);
            cmd.Parameters.AddWithValue("@TG_Longitude",tgrm.TG_Longitude);
            cmd.Parameters.AddWithValue("@TG_latitude",tgrm.TG_latitude);
            cmd.Parameters.AddWithValue("@TG_registration_date",tgrm.TG_registration_date);
            cmd.Parameters.AddWithValue("@TG_registration_time",tgrm.TG_registration_time);
            cmd.Parameters.AddWithValue("@TG_Registration_status",tgrm.TG_Registration_status);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
