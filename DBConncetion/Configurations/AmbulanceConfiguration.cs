using CareOnSpot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CareOnSpot.DBConncetion.Configurations
{
    public class AmbulanceConfiguration : IEntityTypeConfiguration<Ambulance>
    {
        public void Configure(EntityTypeBuilder<Ambulance> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Hospital).WithMany(x => x.Ambulances).HasForeignKey(x => x.HospitalId);
            builder.Property(x => x.DriverName).HasMaxLength(85);
            builder.Property(x => x.ContacNumber).HasMaxLength(20);
            builder.Property(x => x.IsMedicalSupport).HasMaxLength(20);

        }
    }
}
