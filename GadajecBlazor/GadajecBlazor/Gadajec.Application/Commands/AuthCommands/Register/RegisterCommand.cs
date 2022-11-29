using GadajecBlazor.Shared.Auth.Commands.Register;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Commands.AuthCommands.Register
{
    public class RegisterCommand : IRequest
    {
        public UserDto UserDto { get; set; }
    }
}
