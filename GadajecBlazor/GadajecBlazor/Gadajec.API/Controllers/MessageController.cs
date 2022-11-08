using Gadajec.Application.Commands.MessageCommands;
using Microsoft.AspNetCore.Mvc;

namespace Gadajec.API.Controllers
{
    [ApiController]
    [Route("api/messages")]
    public class MessageController : ApiControllerBase
    {
        public MessageController()
        {

        }


        [HttpPost("/send")]
        public async Task<IActionResult> Send(SendMessageCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);

        }

        // HttpContext.Response.StatusCode = 401; --unauthorised | możemy bezpośrednio dostać się do statusu jaki ma być zwrócony.
        // właśność każdego kontrolera
        //return StatusCode(401, $"Hello {właściwość});
        //return NotFound(result); trzecia możliwość zwrócenia kodu
    }
}
