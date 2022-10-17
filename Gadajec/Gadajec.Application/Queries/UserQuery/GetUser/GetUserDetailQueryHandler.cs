using Gadajec.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Queries.UserQuery.GetUser
{
    public class GetUserDetailQueryHandler : IRequestHandler<GetUserDetailQuery, UserDetailVm>
    {
        private readonly IGadajecDBContext _gadajecDBContext;

        public GetUserDetailQueryHandler(IGadajecDBContext gadajecDBContext)
        {
            _gadajecDBContext = gadajecDBContext;
        }
        public async Task<UserDetailVm> Handle(GetUserDetailQuery request, CancellationToken cancellationToken)
        {
            var result = await _gadajecDBContext.Users.Where(u => u.Id == request.UserId).FirstOrDefaultAsync(cancellationToken);

            UserDetailVm userVm = new()
            {
                Name = result.FirstName,   
                Surname = result.LastName
            };

            return userVm;
        }
    }
}
