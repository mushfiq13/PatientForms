using PatientForms.Domain.Entities.Base;

namespace PatientForms.Domain.Entities;

public class Disease : IEntity
{
    public int Id { get; set; }
    public string DiseaseName { get; set; } = null!;
}
