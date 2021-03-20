using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CNW_N8_MVC.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model18")
        {
        }

        public virtual DbSet<banner> banner { get; set; }
        public virtual DbSet<booking_hotel_detail> booking_hotel_detail { get; set; }
        public virtual DbSet<bookings> bookings { get; set; }
        public virtual DbSet<comments> comments { get; set; }
        public virtual DbSet<convenient> convenient { get; set; }
        public virtual DbSet<discount> discount { get; set; }
        public virtual DbSet<hotel_convenient> hotel_convenient { get; set; }
        public virtual DbSet<hotel_rooms> hotel_rooms { get; set; }
        public virtual DbSet<hotel_service> hotel_service { get; set; }
        public virtual DbSet<hotels> hotels { get; set; }
        public virtual DbSet<locations> locations { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<services> services { get; set; }
        public virtual DbSet<users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<banner>()
                .Property(e => e.banner_image)
                .IsUnicode(false);

            modelBuilder.Entity<convenient>()
                .Property(e => e.convenient_image)
                .IsUnicode(false);

            modelBuilder.Entity<convenient>()
                .HasMany(e => e.hotel_convenient)
                .WithRequired(e => e.convenient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<discount>()
                .Property(e => e.discount_id)
                .IsUnicode(false);

            modelBuilder.Entity<hotel_rooms>()
                .Property(e => e.detail_header_image_url_1)
                .IsUnicode(false);

            modelBuilder.Entity<hotel_rooms>()
                .Property(e => e.detail_header_image_url_2)
                .IsUnicode(false);

            modelBuilder.Entity<hotel_rooms>()
                .Property(e => e.detail_header_image_url_3)
                .IsUnicode(false);

            modelBuilder.Entity<hotel_rooms>()
                .Property(e => e.detail_header_image_url_4)
                .IsUnicode(false);

            modelBuilder.Entity<hotel_rooms>()
                .HasMany(e => e.hotel_convenient)
                .WithRequired(e => e.hotel_rooms)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<hotels>()
                .Property(e => e.detail_header_image_url)
                .IsUnicode(false);

            modelBuilder.Entity<hotels>()
                .Property(e => e.hotel_hotline)
                .IsUnicode(false);

            modelBuilder.Entity<hotels>()
                .HasMany(e => e.hotel_convenient)
                .WithRequired(e => e.hotels)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<hotels>()
                .HasMany(e => e.hotel_service)
                .WithRequired(e => e.hotels)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<services>()
                .HasMany(e => e.hotel_service)
                .WithRequired(e => e.services)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<users>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.discount_id)
                .IsUnicode(false);
        }
    }
}
