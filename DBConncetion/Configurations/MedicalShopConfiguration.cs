using CareOnSpot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CareOnSpot.DBConncetion.Configurations
{
    public class MedicalShopConfiguration : IEntityTypeConfiguration<MedicalShop>
    {
        public void Configure(EntityTypeBuilder<MedicalShop> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MedicineName).HasMaxLength(50);
            builder.Property(x => x.Category).HasMaxLength(50);
            builder.Property(x => x.Price).HasMaxLength(50);


        }
    }
}
