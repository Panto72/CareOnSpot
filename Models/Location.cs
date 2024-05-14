using CareOnSpot.Models.Base;

namespace CareOnSpot.Models
{
    public class Location : BaseEntity
    {
        public string? LocationName { get; set; }
        public ICollection<EmergencyHelp> EmergencyHelp { get; set; } = new HashSet<EmergencyHelp>();

    }
}
