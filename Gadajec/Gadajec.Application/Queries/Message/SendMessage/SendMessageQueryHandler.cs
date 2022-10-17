using Gadajec.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Queries.Message.SendMessage
{
    public class SendMessageQueryHandler : IRequestHandler<SendMessageQuery, string>
    {
        private readonly IFileStore _fileStore;

        public SendMessageQueryHandler(IFileStore fileStore)
        {
            _fileStore = fileStore;
        }
        public async Task<string> Handle(SendMessageQuery request, CancellationToken cancellationToken)
        {
            var fileName = $"{request.RoomID}_{request.ReceiverId}.json";
            string jsonString = _fileStore.SafeMessageRead(fileName);

            return jsonString;
        }
    }
}
