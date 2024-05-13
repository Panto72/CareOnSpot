namespace CareOnSpot.Models.Base;

public class BaseEntity : MasterEntity
{
    public int CreatedBy { get; set; }
    public DateTimeOffset CreatedDate { get; set; }
    public int? UpdateBy { get; set; }
    public DateTimeOffset? UpdateDate { get; set; }

}
