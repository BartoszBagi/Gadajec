using Gadajec.Application.Common.Helpers;
using Gadajec.Domain.Entities;
using Gadajec.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Gadajec.Persistance.Services
{
    public static class SeedService
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            Encryptor encryptor = new Encryptor();
            modelBuilder.Entity<User>(u =>
            {
                u.HasData(new User()
                {
                    Id = Guid.NewGuid(),
                    Password = encryptor.Encrypt("Haslo"),
                    Email = "Bartosz@mail.com.pl",
                    CreatedAt = DateTime.Now,
                    FirstName = "Bartosz",
                    LastName = "Bagiński"

                });
            });


            modelBuilder.Entity<Room>().HasData(
                new Room { ID = Guid.NewGuid(), Name = "C# - devs", CreatedBy = "Admin" },
                new Room { ID = Guid.NewGuid(), Name = "SQL - devs", CreatedBy = "Admin" }
                );

        }
    }
}
