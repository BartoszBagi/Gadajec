using Gadajec.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Domain.Entities
{
    public class Contact
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string FriendID { get; set; }
        public string FriendName { get; set; }

        public virtual User User { get; set; }
        public virtual User Friend { get; set; }
    }
}
