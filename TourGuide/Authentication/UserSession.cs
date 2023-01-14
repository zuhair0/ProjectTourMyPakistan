namespace BlazorServerAuthenticationAndAuthorization.Authentication
{
    public class UserSession
    {
        public string UserName { get; set; }
        public string Role { get; set; }
        public int user_fkid { get; set; }
    }
}
