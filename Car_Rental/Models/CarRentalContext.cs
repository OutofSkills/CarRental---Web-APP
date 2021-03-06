using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Models
{
    public class CarRentalContext : DbContext
    {
        public CarRentalContext(DbContextOptions options) : base(options) { }

        /*Configure Many to many*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*set the join table's keys*/
            modelBuilder.Entity<CarLocation>()
                .HasKey(carLoc => new { carLoc.CarID, carLoc.LocationID});

            /*relation between Car and several Locations*/
            modelBuilder.Entity<CarLocation>()
                .HasOne(carLoc => carLoc.Car)
                .WithMany(carLoc => carLoc.CarLocations)
                .HasForeignKey(carLoc => carLoc.CarID);

            /*relation between Location and several Cars*/
            modelBuilder.Entity<CarLocation>()
                .HasOne(carLoc => carLoc.Location)
                .WithMany(carLoc => carLoc.CarsAtLocation)
                .HasForeignKey(carLoc => carLoc.LocationID);
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<BlackList> BlackLists { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarCategory> Categories { get; set; }
        public DbSet<CarTypes> CarTypes { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}
