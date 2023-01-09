using Gadajec.Shared.Rooms.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Queries.Users.AllUsersQueries
{
    public class AllUsersQuery : IRequest<List<ApiUserVm>>
    {
    }
}
