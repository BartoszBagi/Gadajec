using Gadajec.Application.Common.Interfaces;
using Gadajec.Domain.Models;
using Gadajec.Shared.Rooms.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Queries.Rooms.AllRoomsQueries
{
    public class AllRoomsQueryHandler : IRequestHandler<AllRoomsQuery, List<RoomForListVm>>
    {
        private readonly IGadajecDBContext _context;

        public AllRoomsQueryHandler(IGadajecDBContext context)
        {
            _context = context;
        }

        public async Task<List<RoomForListVm>> Handle(AllRoomsQuery request, CancellationToken cancellationToken)
        {
            var rooms = await _context.Rooms.ToListAsync();
            return MapRoomsToVm(rooms);
        }

        private List<RoomForListVm> MapRoomsToVm(List<Room> rooms)
        {
            var result = new List<RoomForListVm>();
            foreach (var room in rooms)
            {
                var roomVm = new RoomForListVm()
                {
                    Name = room.Name,
                    CreatedAt = room.CreatedAt,
                    CreatedBy = room.CreatedBy

                };
                result.Add(roomVm);
            }
            return result;
        }
    }
}
