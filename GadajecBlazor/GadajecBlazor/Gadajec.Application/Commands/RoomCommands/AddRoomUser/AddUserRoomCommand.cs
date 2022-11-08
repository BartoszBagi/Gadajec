using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Commands.RoomCommands.AddRoomUser
{
    public class AddUserRoomCommand : IRequest<string>
    {
        public Guid UserID { get; set; }
        public Guid RoomID { get; set; }

    }
}
