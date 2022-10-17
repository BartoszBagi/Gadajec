using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Queries.Message.SendMessage
{
    public class SendMessageQuery : IRequest<string>
    {
        public Guid RoomID { get; set; }
        public Guid ReceiverId { get; set; }
    }
}
