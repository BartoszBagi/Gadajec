using Gadajec.Application.Commands.RoomCommands.AddRoomUser;
using Gadajec.Application.Commands.RoomCommands.CreateRoom;
using Gadajec.Application.Commands.RoomCommands.DeleteRoom;
using Gadajec.Application.Queries.Rooms.AllRoomsQueries;
using Gadajec.Shared.Rooms.Commands;
using Gadajec.Shared.Rooms.Queries;
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

        [HttpPost]
        [Route("addRoom")]
        public async Task<ActionResult<Guid>> PostAsync([FromBody] AddRoomVm vm)
        {
            var roomGuid = await Mediator.Send(new CreateRoomCommand() {  AdRoomVm = vm });
            return roomGuid;
        }

        [HttpPost]
        [Route("deleteRoom")]
        public async Task<IActionResult> PostAsync([FromBody] string roomName)
        {
            var result = await Mediator.Send(new DeleteRoomCommand() { RoomName = roomName});
            return Ok(result);
        }

        [HttpPost]
        [Route("addUser")]
        public async Task<IActionResult> PostAsync(RoomUserDto roomUser)
        {
            var result = await Mediator.Send(new AddUserRoomCommand() { 
                    RoomUser = roomUser});
            return Ok(result);
        }

        [HttpGet]
        public async Task<List<RoomForListVm>> GetAsync([FromQuery] AllRoomsQuery command)
        {
            var result = await Mediator.Send(command);
            return result;
        }

    }
}
