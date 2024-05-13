using CareOnSpot.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CareOnSpot.DBConncetion;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Hospital> Hospitals { get; set; }
    public DbSet<BloodType> BloodTypes { get; set; }
    public DbSet<BloodDonation> BloodDonations { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<MedicalShop> MedicalShop { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Specialitie> Specialities { get; set; }
    public DbSet<DoctorAppointment> DoctorAppointment { get; set; }
    public DbSet<MedicalTest> MedicalTest { get; set; }
    public DbSet<Ambulance> ambulances { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()).ToList()
               .ForEach(relationship => relationship.DeleteBehavior = DeleteBehavior.Restrict);
    }



}
