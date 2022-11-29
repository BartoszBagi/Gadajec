using Gadajec.Shared.Auth.Commands.Login;

namespace Gadajec.Client.Service.Authentication
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(LoginUserDto loginModel);
        public Task Logout();
    }
}
