using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Domain.Models
{
    public class Room
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        //public virtual List<User> Users { get; set; } = new List<User>();

    }
}
