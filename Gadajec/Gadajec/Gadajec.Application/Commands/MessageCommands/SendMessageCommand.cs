using Gadajec.Shared.Messages.Commands;
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
        public MessageVm Message { get; set; }

        //public List<Attachment> Attachments { get; set; }
    }
}
