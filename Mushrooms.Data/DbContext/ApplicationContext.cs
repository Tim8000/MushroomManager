using System;
using System.Data.Common;
using System.Linq;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;
using Mushrooms.Entities.Entities;

namespace Mushrooms.Data.DbContext
{
    

    public class ApplicationContext : IdentityDbContext<User>
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<MushroomType> MushroomTypes { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestItem> RequestItems { get; set; }
        public DbSet<RequestStatus> RequestStatuses { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
