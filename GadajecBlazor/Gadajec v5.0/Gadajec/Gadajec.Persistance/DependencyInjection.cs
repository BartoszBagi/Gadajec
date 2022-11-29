using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gadajec.Application.Common.Models;
using Gadajec.Application.Common.Interfaces;

namespace Gadajec.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GadajecDBContext>(
                x => x.UseSqlServer(configuration.GetConnectionString("GadajecDatabase"),
                x => x.MigrationsHistoryTable("__Gadajec_MigrationHistory", "Gadajec")));

            services.AddIdentityCore<ApiUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<GadajecDBContext>();

            services.AddScoped<IGadajecDBContext, GadajecDBContext>();

            return services;
        }
    }
}
