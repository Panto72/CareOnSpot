using CareOnSpot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CareOnSpot.DBConncetion.Configurations
{
    public class SpecialitieConfiguration : IEntityTypeConfiguration<Specialitie>
    {
        public void Configure(EntityTypeBuilder<Specialitie> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Title).HasMaxLength(85);
            builder.Property(x=>x.Description).HasMaxLength(250);
            builder.HasData(new Specialitie
            {
                Id = 1,
                Title = "Dermatology",
                Description = "Consult dermatologists for skin, hair, and nail conditions.",
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
            }, new Specialitie
            {
                Id = 2,
                Title = "Ophthalmology",
                Description = "Consult dermatologists for skin, hair, and nail conditions.",
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
            }, new Specialitie
            {
                Id = 3,
                Title = "Pediatrics",
                Description = "Consult dermatologists for skin, hair, and nail conditions.",
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
            }, new Specialitie
            {
                Id = 4,
                Title = "Cardiology",
                Description = "Consult dermatologists for skin, hair, and nail conditions.",
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
            }, new Specialitie
            {
                Id = 5,
                Title = "Psychiatry",
                Description = "Consult dermatologists for skin, hair, and nail conditions.",
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
            }, new Specialitie
            {
                Id = 6,
                Title = "Orthopedics",
                Description = "Consult dermatologists for skin, hair, and nail conditions.",
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
            });
        }
    }
}
