using CareOnSpot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CareOnSpot.DBConncetion.Configurations
{
    public class BloodDonationConfiguration : IEntityTypeConfiguration<BloodDonation>
    {
        public void Configure(EntityTypeBuilder<BloodDonation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.BloodType).WithMany(x => x.BloodDonations).HasForeignKey(x => x.BloodTypeId);
            builder.Property(x => x.DonorName).HasMaxLength(85);
            builder.Property(x => x.ContactNumber).HasMaxLength(20);
            builder.Property(x => x.location).HasMaxLength(85);
            builder.Property(x => x.LastDonationDate).HasMaxLength(85);
        }
    }
}
