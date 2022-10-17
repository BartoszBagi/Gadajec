using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Queries.UserQuery.GetUsers
{
    public class UsersVm
    {
        ICollection<UserDto> Users { get; set; }
    }
}
