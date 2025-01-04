using System.ComponentModel.DataAnnotations;

namespace FarmApi;

public class FieldsDataModel
{
    [Key]
    public Guid Id { get; set; }
    public string FieldName { get; set; }
    public double FieldArea { get; set; }
    public string CropName { get; set; }

    public bool IsDeleted { get; set; } = false;
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public Guid? UpdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
}
