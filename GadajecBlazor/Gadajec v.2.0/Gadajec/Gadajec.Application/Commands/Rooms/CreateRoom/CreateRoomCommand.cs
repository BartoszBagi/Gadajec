using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Commands.Rooms.CreateRoom
{
    public class CreateRoomCommand : IRequest<bool>
    {
        public string Name { get; set; }
        public string CreatedBy { get; set; }
    }
}
