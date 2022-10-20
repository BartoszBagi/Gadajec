using Gadajec.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Commands.MessageCommand.SendMessage
{
    public class SendMessageCommandHandler : IRequestHandler<SendMessageCommand, string>
    {
        private readonly IFileStore _fileStore;
        private static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public SendMessageCommandHandler(IFileStore fileStore)
        {
            _fileStore = fileStore;
        }
        public async Task<string> Handle(SendMessageCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var fileName = $"{request.RoomID}_{request.ReceiverId}.json";
                string jsonString = _fileStore.SafeMessageRead(fileName);

                return jsonString;
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                throw;
            }
                       
        }
    }
}
