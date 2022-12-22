using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryModel;
namespace ClassLibraryDAL
{
    public class UserRegistrationDAL
    {
        public static int SaveUser(UserRegistrationModel urm)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_UserReg", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name",urm.Name);
            cmd.Parameters.AddWithValue("@Mobile",urm.Mobile);
            cmd.Parameters.AddWithValue("@Email",urm.Email);
            cmd.Parameters.AddWithValue("@Address",urm.Address);
            cmd.Parameters.AddWithValue("@UserName", urm.UserName);
            cmd.Parameters.AddWithValue("@Password", urm.Password);
            cmd.Parameters.AddWithValue("@Userrole", urm.Userrole);
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        public static List<UserRegistrationModel> GetUsers()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetRegUsers", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<UserRegistrationModel> usersList = new List<UserRegistrationModel>();
            while (sdr.Read())
            {
                UserRegistrationModel user = new UserRegistrationModel();
                user.ID = int.Parse(sdr["ID"].ToString());
                user.Name = sdr["Name"].ToString();
                user.Mobile = long.Parse(sdr["Mobile"].ToString());
                user.Email = sdr["Email"].ToString();
                user.Address = sdr["Address"].ToString();
                user.Address = sdr["UserName"].ToString();
                user.Address = sdr["Password"].ToString();
                usersList.Add(user);
            }
            con.Close();
            return usersList;
        }
        public static int DeleteUser(int ID)
        {
            SqlConnection con= DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_DeleteUser", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", ID);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

    }
}
