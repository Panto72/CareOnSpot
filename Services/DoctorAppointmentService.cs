using CareOnSpot.DBConncetion;
using CareOnSpot.Models;
using CareOnSpot.Services.Base;

namespace CareOnSpot.Services
{
    public class DoctorAppointmentService : BaseService<DoctorAppointment>, IDoctorAppointmentService
    {
        public DoctorAppointmentService(AppDbContext context) : base(context)
        {
        }
    }
}
