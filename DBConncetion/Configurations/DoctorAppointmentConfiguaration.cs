using CareOnSpot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CareOnSpot.DBConncetion.Configurations
{
    public class DoctorAppointmentConfiguaration : IEntityTypeConfiguration<DoctorAppointment>
    {
        public void Configure(EntityTypeBuilder<DoctorAppointment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Specialitie).WithMany(x => x.DoctorAppointment).HasForeignKey(x => x.SpecialitieId);
            builder.HasOne(x => x.Doctor).WithMany(x => x.DoctorAppointment).HasForeignKey(x => x.DoctorId);
            builder.Property(x => x.FullName).HasMaxLength(85);
            builder.Property(x => x.PhoneNumber).HasMaxLength(20);
            builder.Property(x => x.PreferredDate).IsRequired();
            builder.Property(x => x.ConferenceLink).HasMaxLength(255);
            builder.Property(x => x.Status).HasMaxLength(50);
        }



    }
}

