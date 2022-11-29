
using Gadajec.Application.Commands.Auth.Register;
using Gadajec.Application.Queries.Auth.Login;
using Gadajec.Shared.Auth.Commands.Login;
using Gadajec.Shared.Auth.Commands.Register;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Gadajec.Server.Controllers
{
    [Route("api/auth")]
    [AllowAnonymous]

    public class AuthController : ApiControllerBase
    {
        private readonly IConfiguration configuration;

        public AuthController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(UserDto userDto)
        {
            try
            {
                await Mediator.Send(new RegisterCommand() { UserDto = userDto });
                return Accepted();
            }
            catch (Exception)
            {

                return Problem($"Something Went Wrong in the {nameof(Register)}", statusCode: 500);
            }
        }
        [HttpPost]
        [Route("login")]
        public async Task<AuthResponse> Login(LoginUserDto userDto)
        {
            try
            {
                var response = await Mediator.Send(new LoginQuery() { UserDto = userDto });

                return response;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
