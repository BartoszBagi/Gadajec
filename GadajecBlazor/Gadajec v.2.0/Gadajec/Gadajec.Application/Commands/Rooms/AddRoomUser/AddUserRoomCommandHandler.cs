using Gadajec.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Commands.Rooms.AddRoomUser
{
    //public class AddUserRoomCommandHandler : IRequestHandler<AddUserRoomCommand, string>
    //{
    //    //private readonly IGadajecDBContext _gadajecDbContext;

    //    //public AddUserRoomCommandHandler(IGadajecDBContext gadajecDBContext)
    //    //{
    //    //    _gadajecDbContext = gadajecDBContext;
    //    //}

    //    //public async Task<string> Handle(AddUserRoomCommand request, CancellationToken cancellationToken)
    //    //{
    //    //    try
    //    //    {

    //    //        //var room = _gadajecDbContext.Rooms.FirstOrDefault(r => r.Id.ToString().ToUpper() == request.RoomID.ToString().ToUpper());
    //    //        var room = _gadajecDbContext.Rooms.FirstOrDefault(r => r.Id == request.RoomID);
    //    //        var userToAdd = _gadajecDbContext.Users.FirstOrDefault(u => u.Id == request.UserID);

    //    //        room.Users.Add(userToAdd);

    //    //        await _gadajecDbContext.SaveChangesAsync(true);

    //    //        return userToAdd.FirstName;
    //    //    }
    //    //    catch (Exception ex)
    //    //    {

    //    //        return $"{ex.Message}";
    //    //    }

    //    //}
    //}
}
