using CareOnSpot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CareOnSpot.DBConncetion.Configurations
{
    public class MedicalTestConfiguration : IEntityTypeConfiguration<MedicalTest>
    {
        public void Configure(EntityTypeBuilder<MedicalTest> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TestName).HasMaxLength(45);
            builder.Property(x => x.Price).HasMaxLength(10);
            builder.Property(x => x.Status).HasMaxLength(20);
            builder.Property(x => x.PaymentStatus).HasMaxLength(20);
            builder.HasOne(x => x.Hospital).WithMany(x => x.MedicalTests).HasForeignKey(x => x.HospitalId);
        }
    }
}
