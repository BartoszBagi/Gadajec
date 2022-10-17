using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Interfaces
{
    public interface IUserRepository
    {
        Task GetAsync(int userId);
        Task GetAsync(Func<object, bool> p);
    }
}
