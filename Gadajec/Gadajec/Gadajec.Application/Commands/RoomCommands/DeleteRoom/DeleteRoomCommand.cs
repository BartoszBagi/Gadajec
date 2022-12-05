using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Commands.RoomCommands.DeleteRoom
{
    public class DeleteRoomCommand : IRequest<bool>
    {
        public Guid RoomId { get; set; }
    }
}
