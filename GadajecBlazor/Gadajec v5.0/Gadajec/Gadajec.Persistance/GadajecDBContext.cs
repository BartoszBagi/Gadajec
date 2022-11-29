using Gadajec.Application.Common.Interfaces;
using Gadajec.Application.Common.Models;
using Gadajec.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Persistance
{
    public class GadajecDBContext : IdentityDbContext<ApiUser>, IGadajecDBContext
    {

        public string Schema { get; } = "Gadajec";
        //public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Message> Messages { get; set; }

        public GadajecDBContext(DbContextOptions<GadajecDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema(Schema);
            // ApplyConfiguration dodaje konfiguracje entitis które rozszerzają IEntityTypeConfiguration //
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

    }
}
