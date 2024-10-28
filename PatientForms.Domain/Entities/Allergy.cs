using PatientForms.Domain.Entities.Base;

namespace PatientForms.Domain.Entities;

public class Allergy : IEntity
{
    public int Id { get; set; }
    public string AllergyName { get; set; } = null!;
    public List<PatientAllergy> PatientAllergies { get; } = new();
}