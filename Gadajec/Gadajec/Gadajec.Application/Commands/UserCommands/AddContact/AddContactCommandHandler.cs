using Gadajec.Application.Common.Interfaces;
using Gadajec.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Commands.UserCommands.AddContact
{
    public class AddContactCommandHandler : IRequestHandler<AddContactCommand, bool>
    {
        private readonly IGadajecDBContext context;

        public AddContactCommandHandler(IGadajecDBContext context)
        {
            this.context = context;
        }

        public async Task<bool> Handle(AddContactCommand request, CancellationToken cancellationToken)
        {          
            bool result = false;

            try
            {
                var userAddContactTo = context.Users.FirstOrDefault(u => u.Email == request.Contact.ApiUserEmail);
                var contact = context.Users.FirstOrDefault(u => u.Email == request.Contact.ContactEmail);
                if (userAddContactTo.Contacts.FirstOrDefault(u => u.ContactEmail == request.Contact.ContactEmail) == null)
                {
                    var contactToAdd = new Contact()
                    {
                        ApiUserName = userAddContactTo.Email,
                        ContactEmail = contact.Email,
                        ContactFirstName = contact.FirstName,
                        ContactLastName = contact.LastName
                    };
                    userAddContactTo.Contacts.Add(contactToAdd);

                    await context.SaveChangesAsync(true);
                    
                    result = true;
                }
            }
            catch (Exception e)
            {
                return result;
                throw e;
            }

            return result;
        }
    }
}
