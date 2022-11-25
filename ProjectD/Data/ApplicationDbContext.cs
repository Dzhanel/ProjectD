using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectD.Data.Entities;

namespace ProjectD.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Announcment> Announcments { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Racer> Racers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}