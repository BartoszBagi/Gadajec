using Gadajec.Application.Common.Interfaces;
using Gadajec.Application.Common.Models;
using Gadajec.Shared.Rooms.Queries;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Queries.Users.AllUsersQueries
{
    public class AllUsersQueryCommand : IRequestHandler<AllUsersQuery, List<ApiUserVm>>
    {
        private readonly IGadajecDBContext context;

        public AllUsersQueryCommand(IGadajecDBContext context)
        {
            this.context = context;
        }
        public async Task<List<ApiUserVm>> Handle(AllUsersQuery request, CancellationToken cancellationToken)
        {
            var allUsersVm = new List<ApiUserVm>();
            var users = context.Users.ToList();
            
            foreach (var user in users)
            {
                var rooms = new List<RoomForListVm>();
                foreach (var room in user.Rooms)
                {
                    var roomToMap = new RoomForListVm()
                    {
                        CreatedAt = room.CreatedAt,
                        Description = room.Description,
                        Id = room.Id,
                        CreatedBy = room.CreatedBy,
                        Name = room.Name
                    };
                    rooms.Add(roomToMap);
                }
                var userVm = new ApiUserVm()
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Rooms = rooms 
                };
                allUsersVm.Add(userVm);
            }
            return allUsersVm;
        }
    }
}
