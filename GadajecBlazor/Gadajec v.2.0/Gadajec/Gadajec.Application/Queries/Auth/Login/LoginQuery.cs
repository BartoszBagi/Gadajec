using Gadajec.Shared.Auth.Commands.Login;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Queries.Auth.Login
{
    public class LoginQuery : IRequest<AuthResponse>
    {
        public LoginUserDto UserDto { get; set; }
    }
}
