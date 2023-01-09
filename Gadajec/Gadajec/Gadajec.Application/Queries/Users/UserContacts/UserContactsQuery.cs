using Gadajec.Shared.Users.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Queries.Users.UserContacts
{
    public class UserContactsQuery : IRequest<List<ContactVm>>
    {
        public string UserName { get; set; }
    }
}
