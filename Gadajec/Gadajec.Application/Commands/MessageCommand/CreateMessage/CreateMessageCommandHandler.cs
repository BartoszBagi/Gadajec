using Gadajec.Application.Common.Interfaces;
using Gadajec.Domain.Entities;
using MediatR;
using System.Linq;
using System.Net.Sockets;
using System.Text.Json;

namespace Gadajec.Application.Commands.MessageCommand.CreateMessage
{
    public class CreateMessageCommandHandler : IRequestHandler<CreateMessageCommand, bool>
    {
        private readonly IGadajecDBContext _context;
        private readonly IFileStore _fileStore;
        private static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public CreateMessageCommandHandler(IGadajecDBContext context, IFileStore fileStore)
        {
            _context = context;
            _fileStore = fileStore;
        }


        public async Task<bool> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
        {
            bool result = false;
            //tu zrobić mapowanie
            Message message = new Message() 
            { 
                RoomID = request.RoomID, 
                SenderId = request.SenderId, 
                MessageDate = request.MessageDate, 
                MessageText = request.MessageText, 
                                                
            };
            try
            {

            foreach (var receiver in _context.Rooms.FirstOrDefault(ru => ru.ID == request.RoomID).Users.Where(u => u.Id != request.SenderId))
                {
                    var fileName = $"{request.RoomID}_{receiver.Id}.json";                                                 
                    result = _fileStore.SafeMessageWrite(fileName, message);
                }

                return result;
            }

            catch (Exception ex)
            {
                _logger.Error($"Exception: {ex.Message}");
                return result;
            }
        }


    }
}
