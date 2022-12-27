using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gadajec.Domain.Models;
using Microsoft.AspNetCore.Identity;

namespace Gadajec.Application.Common.Models
{
    public class ApiUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual List<Room> Users { get; set; } = new List<Room>();

    }
}
