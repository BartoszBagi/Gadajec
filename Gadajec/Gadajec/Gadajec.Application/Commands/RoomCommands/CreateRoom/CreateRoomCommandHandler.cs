using Gadajec.Application.Common.Interfaces;
using Gadajec.Domain.Models;
using MediatR;

namespace Gadajec.Application.Commands.RoomCommands.CreateRoom
{
    public class CreateRoomCommandHandler : IRequestHandler<CreateRoomCommand, Guid>
    {
        private readonly IGadajecDBContext context;

        public CreateRoomCommandHandler(IGadajecDBContext gadajecDBContext)
        {
            context = gadajecDBContext;

        }

        public async Task<Guid> Handle(CreateRoomCommand request, CancellationToken cancellationToken)
        {
            try
            {
                if (context.Rooms.Any(r => r.Name == request.AdRoomVm.Name))
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


                    context.Rooms.Add(room);
                    await context.SaveChangesAsync(true);

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
