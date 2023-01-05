using Gadajec.Shared.Messages.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Shared.Messages.PreviousChatArchive
{
    public class PreviousChat
    {
        public List<MessageVm> Messages { get; set; } = new List<MessageVm>();
    }
}
