using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Commands.MessageCommands
{
    public class SendMessageCommand : IRequest<bool>
    {
        public Guid RoomID { get; set; }
        public Guid SenderId { get; set; }
        public DateTime MessageDate { get; set; }
        public string MessageText { get; set; } = "";

        //public List<Attachment> Attachments { get; set; }
    }
}
