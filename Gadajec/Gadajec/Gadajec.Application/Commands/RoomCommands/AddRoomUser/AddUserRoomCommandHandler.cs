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
        private readonly IGadajecDBContext _gadajecDbContext;
        private readonly UserManager<ApiUser> _usermanager;

        public AddUserRoomCommandHandler(IGadajecDBContext gadajecDBContext, UserManager<ApiUser> usermanager)
        {
            _gadajecDbContext = gadajecDBContext;
            _usermanager = usermanager;
        }

        public async Task<bool> Handle(AddUserRoomCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var room = _gadajecDbContext.Rooms.FirstOrDefault(r => r.Name == request.RoomUser.RoomName);

                var userToAdd = await _usermanager.FindByNameAsync(request.RoomUser.UserName);
                
                if (room.Users.Where(u => u.Email == userToAdd.Email).Count() == 0) 
                {
                    room.Users.Add(userToAdd);
                    _gadajecDbContext.Rooms.Attach(room);
                    await _gadajecDbContext.SaveChangesAsync(true);
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
