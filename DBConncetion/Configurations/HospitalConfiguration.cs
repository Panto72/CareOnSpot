using CareOnSpot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CareOnSpot.DBConncetion.Configurations;

public class HospitalConfiguration : IEntityTypeConfiguration<Hospital>
{
    public void Configure(EntityTypeBuilder<Hospital> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(85);
        builder.Property(x => x.Location).HasMaxLength(85);
        builder.Property(x => x.Address).HasMaxLength(200);
        builder.Property(x => x.ContactNumber).HasMaxLength(20);
    }
}
