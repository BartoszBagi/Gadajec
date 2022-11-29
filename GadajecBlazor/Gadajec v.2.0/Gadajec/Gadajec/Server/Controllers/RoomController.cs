using Gadajec.Application.Commands.Rooms.AddRoomUser;
using Gadajec.Application.Commands.Rooms.CreateRoom;
using Gadajec.Application.Commands.Rooms.DeleteRoom;
using Microsoft.AspNetCore.Mvc;

namespace Gadajec.Server.Controllers
{
    [ApiController]
    [Route("api/rooms")]
    public class RoomController : ApiControllerBase
    {
        public RoomController()
        {

        }

        [HttpPost("/addRoom")]
        public async Task<IActionResult> Add(CreateRoomCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("/deleteRoom")]
        public async Task<IActionResult> Delete(DeleteRoomCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("/addUser")]
        public async Task<IActionResult> AddUser(AddUserRoomCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}
