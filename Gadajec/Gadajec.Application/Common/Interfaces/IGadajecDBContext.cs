using Gadajec.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gadajec.Application.Common.Interfaces
{
    public interface IGadajecDBContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }

        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
    }
}
