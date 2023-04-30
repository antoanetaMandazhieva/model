
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using model.Data.Models;

namespace model.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>()
                .HasIndex(x => x.UserName)
                .IsUnique();
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
    }
}