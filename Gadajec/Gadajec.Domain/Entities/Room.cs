using Gadajec.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Domain.Entities
{
    public class Room 
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }


        public virtual List<User> Users { get; set; }

    }
}
