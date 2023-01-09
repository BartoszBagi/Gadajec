using Gadajec.Application.Common.Interfaces;
using Gadajec.Application.Common.Models;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Commands.RoomCommands.AddRoomUser
{
    public class AddUserRoomCommandHandler : IRequestHandler<AddUserRoomCommand, bool>
    {
        private static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private readonly IGadajecDBContext _context;

        public AddUserRoomCommandHandler(IGadajecDBContext gadajecDBContext)
        {
            _context = gadajecDBContext;
        }

        public async Task<bool> Handle(AddUserRoomCommand request, CancellationToken cancellationToken)
        {
            try
            {               
                var room = _context.Rooms.FirstOrDefault(r => r.Name == request.RoomUser.RoomName);
                var userToAdd = _context.Users.FirstOrDefault(u => u.UserName == request.RoomUser.UserName);

                if (room.Users.Where(u => u.Email == userToAdd.Email).Count() == 0) 
                {
                    room.Users.Add(userToAdd);
                    await _context.SaveChangesAsync(true);
                }

                return true;
            }
            catch (Exception ex)
            {
                _logger.Info($"Exception: {ex.Message}");
                return false;
            }

        }

    }
}
