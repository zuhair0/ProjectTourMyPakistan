using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClassLibraryModel;

namespace ClassLibraryDAL
{
    public class TourismDAL
    {
        public static int SaveCity(TourismModel tm)
        {
           SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_SaveCity", con);
            cmd.CommandType=System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@City_name", tm.City_name);
            cmd.Parameters.AddWithValue("@City_Code", tm.City_code);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public static List<TourismModel> GetCities()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetCities", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<TourismModel> TourismList=new List<TourismModel>();
            while (sdr.Read())
            {
                TourismModel tourism = new TourismModel();
                tourism.City_name = sdr["City_name"].ToString();
                tourism.City_code = int.Parse(sdr["City_code"].ToString());
                TourismList.Add(tourism);
            }
            con.Close();
            return TourismList;
        }
        public static int DeleteCity(int city_code)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_DeleteCity",con);
            cmd.CommandType= System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@City_code", city_code);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
