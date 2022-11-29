using Gadajec.Application.Common.Interfaces;
using Gadajec.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Commands.MessageCommands
{
    public class SendMessageCommandHandler : IRequestHandler<SendMessageCommand, bool>
    {
        private readonly IGadajecDBContext _context;

        private static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
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

            catch (Exception ex)
            {
                _logger.Error($"Exception: {ex.Message}");

            }
            return result;
        }


    }
}
