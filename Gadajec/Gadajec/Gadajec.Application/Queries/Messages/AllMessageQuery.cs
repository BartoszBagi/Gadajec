using Gadajec.Shared.Messages.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Queries.Messages
{
    public class AllMessageQuery : IRequest<List<MessageVm>>
    {
        public string RoomName { get; set; }

    }
}
