using Gadajec.Domain.ValueObjects;
using MediatR;

namespace Gadajec.Application.Commands.UserCommand.CreateUser
{
    public class CreateUserCommand : IRequest<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
