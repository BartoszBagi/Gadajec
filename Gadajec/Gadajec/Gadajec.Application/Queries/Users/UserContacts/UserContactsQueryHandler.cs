using Gadajec.Application.Common.Interfaces;
using Gadajec.Application.Common.Models;
using Gadajec.Shared.Users.Commands;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Queries.Users.UserContacts
{
    public class UserContactsQueryHandler : IRequestHandler<UserContactsQuery, List<ContactVm>>
    {
        private readonly IGadajecDBContext context;

        public UserContactsQueryHandler(IGadajecDBContext context)
        {
            this.context = context;
        }
        public async Task<List<ContactVm>> Handle(UserContactsQuery request, CancellationToken cancellationToken)
        {
            var user = context.Users.FirstOrDefault(u => u.Email == request.UserName);
            var userContacts = user.Contacts.ToList();
 
            var contacts = context.Contacts.Where(c => c.ApiUserName == request.UserName).ToList();
            var contactsVm = new List<ContactVm>();
            foreach (var contact in contacts)
            {
                var contactVm = new ContactVm()
                {
                    ApiUserEmail = contact.ApiUserName,
                    ContactEmail = contact.ContactEmail,
                    ContactFirstName = contact.ContactFirstName,
                    ContactLastName = contact.ContactLastName
                };
                contactsVm.Add(contactVm);
            }

            return contactsVm;
        }
    }
}
