using MediatR;

namespace Gadajec.Application.Commands.UserCommand.LogInUser
{
    public class LogInUserCommand : IRequest<Guid>
    {
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
