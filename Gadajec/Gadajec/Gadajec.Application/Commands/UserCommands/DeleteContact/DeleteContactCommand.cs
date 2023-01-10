using Gadajec.Shared.Users.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Commands.UserCommands.DeleteContact
{
    public class DeleteContactCommand : IRequest<bool>
    {
        public Shared.Users.Commands.DeleteContact ContactToDelete { get; set; }
    }
}
