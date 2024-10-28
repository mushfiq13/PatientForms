using PatientForms.Domain.Entities.Base;

namespace PatientForms.Domain.Entities;

public class NCD : IEntity
{
    public int Id { get; set; }
    public string NcdName { get; set; } = null!;
    public List<PatientNCD> PatientNcds { get; set; } = new();
}
