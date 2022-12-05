using Gadajec.Shared.Rooms.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Queries.Rooms.AllRoomsQueries
{
    public class AllRoomsQuery : IRequest<List<RoomForListVm>>
    {
    }
}
