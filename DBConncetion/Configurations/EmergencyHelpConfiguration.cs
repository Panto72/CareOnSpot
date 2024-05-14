using CareOnSpot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CareOnSpot.DBConncetion.Configurations
{
    public class EmergencyHelpConfiguration : IEntityTypeConfiguration<EmergencyHelp>
    {
        public void Configure(EntityTypeBuilder<EmergencyHelp> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PaitentName).HasMaxLength(85);
            builder.Property(x => x.Age).HasMaxLength(50);
            builder.Property(x => x.Gender).HasMaxLength(50);
            builder.Property(x => x.MobileNumber).HasMaxLength(20);
            builder.Property(x => x.Description).HasMaxLength(150);
            builder.Property(x => x.PickUpSopt).HasMaxLength(150);
            builder.Property(x => x.ConfirmStatus).HasMaxLength(30);
            builder.HasOne(x => x.Hospital).WithMany(x => x.EmergencyHelps).HasForeignKey(x => x.HospitalId);
            builder.HasOne(x => x.Ambulance).WithMany(x => x.EmergencyHelps).HasForeignKey(x => x.AmbulanceId);
            builder.HasOne(x => x.Location).WithMany(x => x.EmergencyHelp).HasForeignKey(x => x.LocationId);
        }
    }
}
