using Gadajec.Application.Common.Models;
using GadajecBlazor.Shared.Auth.Commands.Register;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Commands.AuthCommands.Register
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand>
    {
        private readonly UserManager<ApiUser> userManager;
        public RegisterCommandHandler(UserManager<ApiUser> userManager)
        {
            this.userManager = userManager;
        }
        public async Task<Unit> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            ApiUser user = MapDtoToApiUser(request.UserDto);
            user.UserName = request.UserDto.Email;
            var result = await userManager.CreateAsync(user, request.UserDto.Password);

            if (result.Succeeded == false)
            {

            }
            await userManager.AddToRoleAsync(user, "User");

            return Unit.Value;
        }

        private ApiUser MapDtoToApiUser(UserDto userDto)
        {
            return new ApiUser()
            {
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Email = userDto.Email
            };
        }
    }
}
