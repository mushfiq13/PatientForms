using PatientForms.Domain.Entities.Base;

namespace PatientForms.Domain.Entities;

public class PatientNCD : IEntity
{
    public int Id { get; set; }
    public int PatientId { get;set; }
    public Patient Patient { get; set; } = null!;
    public int NcdId { get; set; }
    public NCD Ncd { get; set; } = null!;
}

