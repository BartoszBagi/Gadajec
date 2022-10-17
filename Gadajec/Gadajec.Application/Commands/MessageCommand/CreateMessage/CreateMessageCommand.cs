using Gadajec.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Commands.MessageCommand.CreateMessage
{
    public class CreateMessageCommand : IRequest<bool>
    {
        public Guid RoomID { get; set; }
        public Guid SenderId { get; set; }
        public DateTime MessageDate { get; set; }
        public string MessageText { get; set; }

        //public List<Attachment> Attachments { get; set; }

    }
}
