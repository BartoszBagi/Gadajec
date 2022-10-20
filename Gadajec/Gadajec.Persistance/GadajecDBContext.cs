using Gadajec.Application.Common.Interfaces;
using Gadajec.Domain.Common;
using Gadajec.Domain.Entities;
using Gadajec.Persistance.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Gadajec.Persistance
{
    public class GadajecDBContext : DbContext, IGadajecDBContext
    {
        private readonly IDateTime _dateTime;

        public string Schema { get; } = "Gadajec";
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }

        public GadajecDBContext(DbContextOptions<GadajecDBContext> options, IDateTime dateTime) : base(options)
        {
            _dateTime = dateTime;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(Schema);
            // ApplyConfiguration dodaje konfiguracje entitis które rozszerzają IEntityTypeConfiguration //
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //seedujemy dane
           //modelBuilder.SeedData();
            
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = string.Empty;
                        entry.Entity.Created = _dateTime.Now;
                        entry.Entity.StatusId = 1;
                        break;

                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Modified = _dateTime.Now;
                        entry.Entity.Inactivated = _dateTime.Now;
                        entry.Entity.InactivatedBy = string.Empty;
                        entry.Entity.StatusId = 0;
                        entry.State = EntityState.Modified;
                        break;

                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Modified = _dateTime.Now;
                        break;

                    default:
                        break;
                }
            }
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

    }
}
