using Gadajec.Application.Common.Interfaces;
using Gadajec.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Commands.RoomCommands.CreateRoom
{
    public class CreateRoomCommandHandler : IRequestHandler<CreateRoomCommand, Guid>
    {
        private readonly IGadajecDBContext _gadajecDBContext;

        public CreateRoomCommandHandler(IGadajecDBContext gadajecDBContext)
        {
            _gadajecDBContext = gadajecDBContext;

        }

        public async Task<Guid> Handle(CreateRoomCommand request, CancellationToken cancellationToken)
        {
            try
            {
                if (_gadajecDBContext.Rooms.Any(r => r.Name == request.AdRoomVm.Name))
                {
                    return Guid.Empty;
                }

                else
                {
                    Room room = new Room()
                    {
                        Id = Guid.NewGuid(),
                        Name = request.AdRoomVm.Name,
                        CreatedBy = request.AdRoomVm.CreatedBy,
                        CreatedAt = request.AdRoomVm.CreatedAt,
                        Description = request.AdRoomVm.Description
                    };


                    _gadajecDBContext.Rooms.Add(room);
                    await _gadajecDBContext.SaveChangesAsync(true);

                    return room.Id;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

    }
}
