using Gadajec.Application.Common.Interfaces;
using Gadajec.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Commands.UserCommands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
    {
        private static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private readonly IGadajecDBContext _gadajecDBContext;
        private readonly IEncryptor _encryptor;
        private readonly IDateTime _dateTime;

        public CreateUserCommandHandler(IGadajecDBContext gadajecDBContext, IEncryptor encryptor, IDateTime dateTime)
        {
            _gadajecDBContext = gadajecDBContext;
            _encryptor = encryptor;
            _dateTime = dateTime;

        }
        public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {

            if (_gadajecDBContext.Users.Any(su => su.Email == request.Email))
            {
                return Guid.Empty;
            }

            User u = new User()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Password = _encryptor.Encrypt(request.Password),
                Email = request.Email,
                CreatedAt = _dateTime.Now,
            };

            _gadajecDBContext.Users.Add(u);
            await _gadajecDBContext.SaveChangesAsync(true);


            if (_gadajecDBContext.Users.Any(su => su.Id == u.Id))
            {
                return u.Id;
            }
            else
            {
                return Guid.Empty;
            }
        }
    }
}
