using Gadajec.Shared.Rooms.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Commands.RoomCommands.AddRoomUser
{
    public class AddUserRoomCommand : IRequest<bool>
    {
        public RoomUserDto RoomUser { get; set; }

    }
}
