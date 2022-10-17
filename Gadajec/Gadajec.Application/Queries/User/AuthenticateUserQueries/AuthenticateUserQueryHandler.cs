using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Queries.User.AuthenticateUserQueries
{
    public class AuthenticateUserQueryHandler : IRequestHandler<AuthenticateUserQuery, int>
    {
        public async Task<int> Handle(AuthenticateUserQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
