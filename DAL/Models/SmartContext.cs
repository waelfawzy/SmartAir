using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SmartContext : DbContext
    {

    public SmartContext(DbContextOptions<SmartContext> options) : base(options) { }
        public DbSet<User> Users { set; get; }
        public DbSet<Role> Roles { set; get; }
        public DbSet<Permission> Permissions { set; get; }
        public DbSet<RolePermissions> RolePermissions { set; get; }
        public DbSet<AirPort> AirPorts { set; get; }
        public DbSet<BusinessOffer> BusinessOffers { set; get; }
        public DbSet<Country> Countries { set; get; }
        public DbSet<Currency> Currency { set; get; }
        public DbSet<DisabilityType> DisabilityTypes { set; get; }
        public DbSet<Events> Events { set; get; }
        public DbSet<Field> Fields { set; get; }
        public DbSet<FieldEvents> FieldsEvents { set; get; }
        public DbSet<FieldValidations> FieldsValidations { set; get; }
        public DbSet<Flight> Flights { set; get; }
        public DbSet<Garage> Garages { set; get; }
        public DbSet<LabPcrType> LabPcrTypes { set; get; }
        public DbSet<Organization> Organizations { set; get; }
        public DbSet<OrganizationPackag> OrganizationPackags { set; get; }
        public DbSet<OrganizationType> OrganizationTypes { set; get; }
        public DbSet<PaymentType> PaymentTypes { set; get; }
        public DbSet<PcrType> PcrTypes { set; get; }
        public DbSet<Plane> Planes { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductUnits> ProductUnits { set; get; }
        public DbSet<Reservation> Reservations { set; get; }
        public DbSet<ReservationForm> ReservationForms { set; get; }
        public DbSet<ReservationType> ReservationTypes { set; get; }
        public DbSet<Room> Rooms { set; get; }
        public DbSet<RoomType> RoomTypes { set; get; }
        public DbSet<Seat> Seats { set; get; }
        public DbSet<SuperMarketProducts> SuperMarketProducts { set; get; }
        public DbSet<Terminal> Terminals { set; get; }
        public DbSet<Transportation> Transportations { set; get; }
        public DbSet<TransportationDetails> TransportationDetails { set; get; }
        public DbSet<TransportationType> transportationTypes { set; get; }
        public DbSet<Trip> Trip { set; get; }
        public DbSet<TripTransportation> TripTransportations { set; get; }
        public DbSet<Unit> Units { set; get; }
        public DbSet<UserBusnessOffers> UserBusnessOffers { set;get; }
        public DbSet<UserDisability> UserDisability { set; get; }
        public DbSet<Validations> Validations { set; get; }
        public DbSet<SmartConfigurations> SmartConfigurations { set; get; }
        
    }
}
