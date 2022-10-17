using Gadajec.Domain.Common;
using Gadajec.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        //public UserName UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ContactId { get; set; }
        [NotMapped]
        public List<Contact> ContactList { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
