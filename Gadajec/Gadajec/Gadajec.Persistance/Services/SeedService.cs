﻿using Gadajec.Application.Common.Helpers;
using Gadajec.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Persistance.Services
{
    public static class SeedService
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            //Encryptor encryptor = new Encryptor();
            //modelBuilder.Entity<User>(u =>
            //{
            //    u.HasData(new User()
            //    {
            //        Id = Guid.NewGuid(),
            //        Password = encryptor.Encrypt("Haslo"),
            //        Email = "Bartosz@mail.com.pl",
            //        CreatedAt = DateTime.Now,
            //        FirstName = "Bartosz",
            //        LastName = "Bagiński"

            //    });
            //});


            modelBuilder.Entity<Room>().HasData(
                new Room { Id = Guid.NewGuid(), Name = "MainChat", CreatedBy = "Admin", CreatedAt = DateTime.Today, Description = "Pokój główny" },
                new Room { Id = Guid.NewGuid(), Name = ".Net - devs", CreatedBy = "Admin", CreatedAt = DateTime.Today, Description = "Pokój skierowany dla osób pracujących w środowisku C# .Net" },
                new Room { Id = Guid.NewGuid(), Name = "SQL - devs", CreatedBy = "Admin", CreatedAt = DateTime.Now, Description = "Tutaj porozmawiamy o SQL" }
                );

        }
    }
}
