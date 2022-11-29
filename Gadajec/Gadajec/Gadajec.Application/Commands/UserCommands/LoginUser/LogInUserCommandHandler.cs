using Gadajec.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Commands.UserCommands.LoginUser
{
    public class LogInUserCommandHandler : IRequestHandler<LogInUserCommand, Guid>
    {
        private readonly IGadajecDBContext _dbContext;
        private readonly IEncryptor _encryptor;

        public LogInUserCommandHandler(IGadajecDBContext dbContextService, IEncryptor encryptor)
        {
            _dbContext = dbContextService;
            _encryptor = encryptor;
        }

        public async Task<Guid> Handle(LogInUserCommand request, CancellationToken cancellationToken)
        {
            if (_dbContext.Users.Any(u => u.Email == request.Email && _encryptor.Encrypt(request.Password) == u.Password))
            {
                return _dbContext.Users.FirstOrDefault(u => u.Email == request.Email && _encryptor.Encrypt(request.Password) == u.Password).Id;
            }
            else return Guid.Empty;
        }
    }
}
