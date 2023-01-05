using Gadajec.Application.Commands.MessageCommands;
using Gadajec.Application.Queries.Messages;
using Gadajec.Shared.Messages.Commands;
using Gadajec.Shared.Messages.PreviousChatArchive;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Gadajec.Server.Controllers
{
    [ApiController]
    [Route("api/messages")]
    public class MessageController : ApiControllerBase
    {

        private PreviousChat previousChat { get; set; }

        public MessageController(PreviousChat previousChat)
        {
            this.previousChat = previousChat;
        }


        [HttpGet]
        public IEnumerable<MessageVm> Get()
        {
            return previousChat.Messages;
        }

        [HttpGet("{roomName}")]
        public async Task<List<MessageVm>> GetAsync(string roomName)
        {
            var result = await Mediator.Send(new AllMessageQuery() { RoomName = roomName });
            return result;
        }

        [HttpPost]
        [Route("send")]
        public async Task<IActionResult> PostAsync([FromBody] MessageVm messageVm)
        {
            var result = await Mediator.Send(new SendMessageCommand() { Message = messageVm});
            return Ok(result);

        }

    }
}
