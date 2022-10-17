using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Queries.UserQuery.GetUser
{
    public class GetUserDetailQuery : IRequest<UserDetailVm>
    {
        public Guid UserId { get; set; }
    }
}
