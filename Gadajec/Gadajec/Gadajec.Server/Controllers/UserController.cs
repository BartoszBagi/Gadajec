using Gadajec.Application.Commands.UserCommands.AddContact;
using Gadajec.Application.Queries.Users.AllUsersQueries;
using Gadajec.Application.Queries.Users.UserContacts;
using Gadajec.Shared.Rooms.Queries;
using Gadajec.Shared.Users.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Gadajec.Server.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ApiControllerBase
    {
        public UserController()
        {

        }

        [HttpGet]
        public async Task<List<ApiUserVm>> GetAsync([FromQuery] AllUsersQuery command)
        {
            var result = await Mediator.Send(command);
            return result;
        }

        [HttpGet("{userName}")]
        public async Task<List<ContactVm>> GetAsync(string userName)
        {
            var result = await Mediator.Send(new UserContactsQuery() { UserName = userName});
            return result;
        }

        [HttpPost]
        [Route("addContact")]
        public async Task<ActionResult<bool>> PostAsync([FromBody] ContactVm vm)
        {
            var result = await Mediator.Send(new AddContactCommand() { Contact = vm });
            return result;
        }
    }
}
