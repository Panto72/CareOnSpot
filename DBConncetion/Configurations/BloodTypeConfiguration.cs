using CareOnSpot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CareOnSpot.DBConncetion.Configurations
{
    public class BloodTypeConfiguration : IEntityTypeConfiguration<BloodType>
    {
        public void Configure(EntityTypeBuilder<BloodType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.BloodGroup).HasMaxLength(50);
        }
    }
}
