namespace Entities.Models.Common;
public abstract class BaseEntity<T>
{
    public T Id { get; set; }
    public string CreatedByUser { get; set; }
    public string? UpdatedByUser { get; set; }
    public string? DeletedByUser { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? DeletedDate { get; set; }
    public bool Status { get; set; }
}