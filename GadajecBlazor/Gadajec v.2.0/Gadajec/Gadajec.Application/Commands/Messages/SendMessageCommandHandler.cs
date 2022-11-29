using Gadajec.Application.Common.Interfaces;
using Gadajec.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Commands.Messages
{
    public class SendMessageCommandHandler : IRequestHandler<SendMessageCommand, bool>
    {
        private readonly IGadajecDBContext _context;


        public SendMessageCommandHandler(IGadajecDBContext context)
        {
            _context = context;
        }


        public async Task<bool> Handle(SendMessageCommand request, CancellationToken cancellationToken)
        {
            bool result = false;

            try
            {
                Message message = new Message()
                {
                    RoomID = request.RoomID,
                    SenderId = request.SenderId,
                    MessageDate = request.MessageDate,
                    MessageText = request.MessageText,

                };

                _context.Messages.Add(message);

                await _context.SaveChangesAsync(true);

                result = true;
            }

            catch (Exception)
            {
                throw;
            }
            return result;
        }


    }
}
