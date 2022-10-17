using FluentValidation;

namespace Gadajec.Application.Commands.UserCommand.CreateUser
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(s => s.Email).EmailAddress();
            RuleFor(s => s.Password).MinimumLength(4);
        }
    }
}
