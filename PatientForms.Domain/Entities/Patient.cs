using PatientForms.Domain.Entities.Base;

namespace PatientForms.Domain.Entities;

public class Patient : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string ContactNumber { get; set; } = null!;
    public int DiseaseInformationId { get; set; }
    public Disease DiseaseInformation { get; set; } = null!;
    public Epilepsy Epilepsy { get; set; }
    public List<PatientNCD> PatientNcd { get; set; } = new();
    public List<PatientAllergy> PatientAllergies { get; set; } = new();
}
