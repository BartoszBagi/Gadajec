using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public virtual List<Contact> Contacts { get; set; } = new List<Contact>();
        public virtual List<Room> Rooms { get; set; } = new List<Room>();

    }
}
