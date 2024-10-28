using PatientForms.Domain.Entities.Base;

namespace PatientForms.Domain.Entities;

public class PatientAllergy : IEntity
{
    public int Id { get; set; }
    public int PatientId { get; set; }
    public Patient Patient { get; set; } = null!;
    public int AllergyId { get; set; }
    public Allergy Allergy { get; set; } = null!;
}
