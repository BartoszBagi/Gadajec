using Gadajec.Shared.Rooms.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Commands.RoomCommands.CreateRoom
{
    public class CreateRoomCommand : IRequest<Guid>
    {
        public AddRoomVm AdRoomVm { get; set; }


    }
}
