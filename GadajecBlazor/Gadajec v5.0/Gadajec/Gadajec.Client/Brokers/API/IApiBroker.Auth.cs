using Gadajec.Shared.Auth.Commands.Login;
using Gadajec.Shared.Auth.Commands.Register;

namespace Gadajec.Client.Brokers.API
{
    public partial interface IApiBroker
    {
        Task<AuthResponse> LoginAsync(LoginUserDto userDto);
        Task RegisterAsync(UserDto user);
    }
}
