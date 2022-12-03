﻿using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using Gadajec.Application.Common.Models;
using GadajecBlazor.Shared.Auth.Commands.Login;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;
using Gadajec.Application.Common.Static;

namespace Gadajec.Application.Queries.Auth.Login
{
    public class LoginQueryHandler : IRequestHandler<LoginQuery, AuthResponse>
    {
        private readonly UserManager<ApiUser> userManager;
        private readonly IConfiguration configuration;

        public LoginQueryHandler(UserManager<ApiUser> userManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.configuration = configuration;
        }
    
        public async Task<AuthResponse> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            var user = await userManager.FindByEmailAsync(request.UserDto.Email);
            var passwordValid = await userManager.CheckPasswordAsync(user, request.UserDto.Password);

            if (user == null || passwordValid == false)
            {
                throw new Exception("Invalid User");
            }

            string tokenString = await GenerateToken(user);

            var response = new AuthResponse
            {
                Email = request.UserDto.Email,
                Token = tokenString,
                UserId = user.Id
            };

            return response;
        }

        private async Task<string> GenerateToken(ApiUser user)
        {
            try
            {
                var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"]));
                var credentials = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);

                var roles = await userManager.GetRolesAsync(user);
                var roleClaims = roles.Select(q => new Claim(ClaimTypes.Role, q)).ToList();

                var userClaims = await userManager.GetClaimsAsync(user);

                var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(CustomClaimTypes.Uid, user.Id)
            }
                .Union(userClaims)
                .Union(roleClaims);

                var token = new JwtSecurityToken(
                    issuer: configuration["JwtSettings:Issuer"],
                    audience: configuration["JwtSettings:Audience"],
                    claims: claims,
                    expires: DateTime.UtcNow.AddHours(Convert.ToInt32(configuration["JwtSettings:Duration"])),
                    signingCredentials: credentials
                    );
                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
