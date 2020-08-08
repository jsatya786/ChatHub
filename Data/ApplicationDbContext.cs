using System;
using System.Collections.Generic;
using System.Text;
using Chatter.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Chatter.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Message> Messages { get; set; }
        //public DbSet<AppUser> appUser { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Message>()
               .HasOne<AppUser>(a => a.Sender)
               .WithMany(x => x.Messages)
               .HasForeignKey(x => x.UserId);
        }
    }
}
