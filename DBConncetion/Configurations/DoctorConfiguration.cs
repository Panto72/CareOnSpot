using CareOnSpot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CareOnSpot.DBConncetion.Configurations
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(85);
            builder.HasOne(x => x.Hospital).WithMany(x => x.Doctors).HasForeignKey(x => x.HospitalId);
            builder.Property(x => x.Designation).HasMaxLength(50);
            builder.Property(x => x.Experience).HasMaxLength(50);
            builder.HasOne(x => x.Specialitie).WithMany(x => x.Doctors).HasForeignKey(x => x.SpecialtyId);
            builder.Property(x => x.VisitFee).HasMaxLength(50);
        }
    }
}
