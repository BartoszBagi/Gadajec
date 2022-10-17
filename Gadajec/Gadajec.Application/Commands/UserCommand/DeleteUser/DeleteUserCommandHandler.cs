﻿using Gadajec.Application.Common.Interfaces;
using MediatR;

namespace Gadajec.Application.Commands.UserCommand.DeleteUser
{

    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, bool>
    {
        private readonly IGadajecDBContext _gadajecDBContext;

        public DeleteUserCommandHandler(IGadajecDBContext gadajecDBContext)
        {
            _gadajecDBContext = gadajecDBContext;
        }
        public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var userToDelete = _gadajecDBContext.Users.FirstOrDefault(u => u.Id == request.Id);

            if (userToDelete != null)
            {
                _gadajecDBContext.Users.Remove(userToDelete);
                await _gadajecDBContext.SaveChangesAsync(true);

                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
