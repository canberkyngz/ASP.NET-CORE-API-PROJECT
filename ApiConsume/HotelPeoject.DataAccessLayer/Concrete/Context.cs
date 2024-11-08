using HotelProject.EntityLayer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("server=localhost;database=HotelDb;integrated security=true;TrustServerCertificate=True");
        }

        //Trigger Hatasının çözümü için
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Room>().ToTable(tb => tb.HasTrigger("RoomDecrease")).ToTable(tb => tb.HasTrigger("Roomincrease"));
            builder.Entity<Staff>().ToTable(tb => tb.HasTrigger("StaffDecrease")).ToTable(tb => tb.HasTrigger("Staffincrease"));
            builder.Entity<Guest>().ToTable(tb => tb.HasTrigger("GuestDecrease")).ToTable(tb => tb.HasTrigger("Guestincrease"));
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings { get; set; }    
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<SendMessage> SendMessages { get; set; }
        public DbSet<MessageCategory> MessageCategories { get; set; }
        public DbSet<WorkLocation> WorkLocations { get; set; }
    }
}
    