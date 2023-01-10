using Gadajec.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Commands.UserCommands.DeleteContact
{
    public class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommand, bool>
    {
        private readonly IGadajecDBContext context;

        public DeleteContactCommandHandler(IGadajecDBContext context)
        {
            this.context = context;
        }
        public async Task<bool> Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
            bool result = false;
            try
            {
                var contactToDelete = context.Contacts.FirstOrDefault(c => c.ApiUserName == request.ContactToDelete.ApiUserEmail
                                                                && c.ContactEmail == request.ContactToDelete.ContactEmail);
                context.Contacts.Remove(contactToDelete);
                result = true;
                await context.SaveChangesAsync(result);
            }
            catch (Exception e)
            {

                throw;
            }

            return result;
        }
    }
}
