using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Models;

namespace WebTest.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasIndex(u => u.Phone)
                .IsUnique();
            base.OnModelCreating(builder);
        }
        public DbSet<User> UsersTable { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
