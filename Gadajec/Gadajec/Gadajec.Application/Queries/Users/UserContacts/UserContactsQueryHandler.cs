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
        private UserManager<ApiUser> usermanager;

        public UserContactsQueryHandler(IGadajecDBContext context, UserManager<ApiUser> usermanager)
        {
            this.context = context;
            this.usermanager = usermanager;
        }
        public async Task<List<ContactVm>> Handle(UserContactsQuery request, CancellationToken cancellationToken)
        {
            var list = new List<ContactVm>();
            var user = context.Users.FirstOrDefault(u => u.Email == request.UserName);
            var userContacts = user.Contacts.ToList();
            var userman = await usermanager.FindByEmailAsync(request.UserName);
            var usermanContacts = userman.Contacts.ToList();

            foreach (var contact in userContacts)
            {
                var contactVm = new ContactVm()
                {
                    ApiUserEmail = contact.ApiUserName,
                    ContactEmail = contact.ContactEmail,
                    ContactFirstName = contact.ContactFirstName,
                    ContactLastName = contact.ContactLastName
                };
                list.Add(contactVm);
            }

            return list;
        }
    }
}
