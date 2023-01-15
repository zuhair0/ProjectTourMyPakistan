using ClassLibraryModel;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.Security.Claims;

namespace BlazorServerAuthenticationAndAuthorization.Authentication
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly ProtectedSessionStorage _sessionStorage;
        private ClaimsPrincipal _anonymous=new ClaimsPrincipal(new ClaimsIdentity());
        private TourGuideRegistrationModel TourGuide = new TourGuideRegistrationModel();

        public CustomAuthenticationStateProvider(ProtectedSessionStorage sessionStorage)
        {
            _sessionStorage = sessionStorage;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                var userSessionStorageResult = await _sessionStorage.GetAsync<UserSession>("UserSession");
                var UserSession = userSessionStorageResult.Success ? userSessionStorageResult.Value : null;
                if (UserSession == null)
                    return await Task.FromResult(new AuthenticationState(_anonymous));
                var claimsPrinciple = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Name,UserSession.UserName),
                    new Claim(ClaimTypes.Role,UserSession.Role) ,
                    new Claim(ClaimTypes.SerialNumber,UserSession.user_fkid.ToString())
                }, "CustomAuth"));
                TourGuide.idd = UserSession.user_fkid.ToString();
                return await Task.FromResult(new AuthenticationState(claimsPrinciple));
            }
            catch
            {
                return await Task.FromResult(new AuthenticationState(_anonymous));
            }
        }
        public async Task UpdateAuthenticationState(UserSession userSession) 
        {
            ClaimsPrincipal claimsPrincipal;
            if(userSession!=null)
            {
                await _sessionStorage.SetAsync("UserSession", userSession);
                claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Name,userSession.UserName),
                    new Claim(ClaimTypes.Role,userSession.Role),
                    new Claim(ClaimTypes.SerialNumber,userSession.user_fkid.ToString())
                }));
            }
            else
            {
                await _sessionStorage.DeleteAsync("UserSession");
                claimsPrincipal = _anonymous;
            }
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
        }
    }
}
