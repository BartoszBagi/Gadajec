using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Shared.Messages.Commands
{
    public class MessageVm
    {
        public string RoomName { get; set; }
        public string SenderName { get; set; }
        public DateTime MessageDate { get; set; }
        public string MessageText { get; set; }
    }
}
