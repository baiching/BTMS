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

        }
    }
}
