using Gadajec.Application.Common.Interfaces;
using Gadajec.Shared.Messages.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Queries.Messages
{
    public class AllMessageQueryHandler : IRequestHandler<AllMessageQuery, List<MessageVm>>
    {
        private readonly IGadajecDBContext context;

        public AllMessageQueryHandler(IGadajecDBContext context)
        {
            this.context = context;
        }
        public async Task<List<MessageVm>> Handle(AllMessageQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var messagesVm = new List<MessageVm>();
                var messages = context.Messages.Where(m => m.MessageDate > DateTime.Today.AddDays(-1) && m.RoomName == request.RoomName).ToList();

                foreach (var message in messages)
                {
                    var messageVm = new MessageVm()
                    {
                        MessageText = message.MessageText,
                        MessageDate = message.MessageDate,
                        SenderName = message.SenderName
                    };
                    messagesVm.Add(messageVm);
                }
                return messagesVm;
            }
            catch (Exception e)
            {
                throw;
            }
            
        }

    }
}
