using Gadajec.Application.Commands.UserCommand.CreateUser;
using Gadajec.Application.Commands.UserCommand.DeleteUser;
using Gadajec.Application.Commands.UserCommand.LogInUser;
using Microsoft.AspNetCore.Mvc;

namespace Gadajec.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ApiControllerBase
    {
        private static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public UserController()
        {
            
        }

        [HttpPost("/add")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Add(CreateUserCommand command)
        {
            try
            {
                var result = await Mediator.Send(command);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.Error($"Exception: {ex.Message}");
                throw;
            }
            
        }

        [HttpPost("/login")]
        public async Task<IActionResult> LogIn(LogInUserCommand command)
        {
            try
            {
                var result = await Mediator.Send(command);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.Error($"Exception: {ex.Message}");
                throw;
            }
            
        }

        [HttpPost("/delete")]
        public async Task<IActionResult> Delete(DeleteUserCommand command)
        {
            try
            {
                var result = await Mediator.Send(command);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.Error($"Exception: {ex.Message}");
                throw;
            }
            
        }

    }
}