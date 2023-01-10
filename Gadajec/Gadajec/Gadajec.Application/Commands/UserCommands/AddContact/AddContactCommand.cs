using Gadajec.Domain.Models;
using Gadajec.Shared.Rooms.Queries;
using Gadajec.Shared.Users.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Commands.UserCommands.AddContact
{
    public class AddContactCommand : IRequest<bool>
    {
        public Shared.Users.Commands.AddContact Contact { get; set; }
    }
}
