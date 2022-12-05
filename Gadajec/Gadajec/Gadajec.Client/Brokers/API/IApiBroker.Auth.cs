using GadajecBlazor.Shared.Auth.Commands.Login;
using GadajecBlazor.Shared.Auth.Commands.Register;


namespace Gadajec.Client.Brokers.API
{
    public partial interface IApiBroker
    {
        Task<AuthResponse> LoginAsync(LoginUserDto userDto);
        Task RegisterAsync(UserDto user);
    }
}
