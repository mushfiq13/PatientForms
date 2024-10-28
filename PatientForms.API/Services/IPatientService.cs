using PatientForms.API.Models;

namespace PatientForms.API.Services;

public interface IPatientService
{
    Task<IEnumerable<dynamic>> GetAll();
    Task Insert(PatientBindingModel patientDto);
}
