using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Entity
{
    public class BtmsContext : DbContext
    {
        public BtmsContext() : base("name=BTMS_DB") { }

        public virtual DbSet<Bus> Buses { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Journey> Journeys { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<RoutePoint> RoutePoints { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Traffic> Traffics { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            ///base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Bus>()
                .HasMany(r => r.Journey)
                .WithRequired(r => r.Bus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Driver>()
                .HasMany(r => r.Journey)
                .WithRequired(r => r.Driver)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Journey>()
                .HasMany(r => r.Ticket)
                .WithRequired(r => r.Journey)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Journey>()
                .HasMany(r => r.Traffic)
                .WithRequired(r => r.Journey)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Passenger>()
                .HasMany(r => r.Ticket)
                .WithRequired(r => r.Passenger)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Route>()
                .HasMany(r => r.Journey)
                .WithRequired(r => r.Route)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoutePoint>()
                .HasMany(r => r.Route)
                .WithRequired(r => r.RoutePoint)
                .HasForeignKey(r => r.ArrivalPointId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ticket>()
                .Property(r => r.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ticket>()
                .HasMany(r => r.Traffic)
                .WithRequired(r => r.Ticket)
                .WillCascadeOnDelete(false);
        }
    }
}
