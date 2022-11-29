using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Commands.UserCommands.LoginUser
{
    public class LogInUserCommand : IRequest<Guid>
    {
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
