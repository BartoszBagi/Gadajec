﻿using Gadajec.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Commands.RoomCommand.DeleteRoom
{
    public class DeleteRoomCommandHandler : IRequestHandler<DeleteRoomCommand, bool>
    {
        private readonly IGadajecDBContext _gadajecDBContext;
       
        public DeleteRoomCommandHandler(IGadajecDBContext gadajecDBContext)
        {
            _gadajecDBContext = gadajecDBContext;
        }
        public async Task<bool> Handle(DeleteRoomCommand request, CancellationToken cancellationToken)
        {
            var roomToDelete = _gadajecDBContext.Rooms.FirstOrDefault(u => u.Id == request.RoomId);

            if (roomToDelete != null)
            {
                _gadajecDBContext.Rooms.Remove(roomToDelete);
                await _gadajecDBContext.SaveChangesAsync(true);

                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
