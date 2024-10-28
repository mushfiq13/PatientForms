using Microsoft.EntityFrameworkCore;
using PatientForms.API.Models;
using PatientForms.EF.Repositories.BaseRepository;

namespace PatientForms.API.Services;

public class PatientService(IRepository<Patient> repository) : IPatientService
{
    public async Task<IEnumerable<dynamic>> GetAll()
    {
        var entityAsQueryable = repository.GetEntityAsIQueryable();
        var patients = await entityAsQueryable
            .Include(x => x.DiseaseInformation)
            .Include(x => x.PatientAllergies)
            .ThenInclude(x => x.Allergy)
            .Include(x => x.PatientNcd)
            .ThenInclude(x => x.Ncd)
            .ToListAsync();

        return patients.Select(x => new
        {
            x.Id,
            x.ContactNumber,
            x.Name,
            x.Epilepsy,
            x.DiseaseInformation,
            Allergies = x.PatientAllergies.Select(x => new { x.Allergy.Id, x.Allergy.AllergyName }),
            Ncds = x.PatientNcd.Select(x => new { x.Ncd.Id, x.Ncd.NcdName })
        });
    }

    public async Task Insert(PatientBindingModel patientDto)
    {
        var patientToInsert = new Patient
        {
            Name = patientDto.Name,
            ContactNumber = patientDto.ContactNumber,
            Epilepsy = patientDto.Epilepsy,
            DiseaseInformationId = patientDto.DiseaseId
        };
        patientToInsert.PatientAllergies =
            patientDto.Allergies.Select(x => new PatientAllergy { AllergyId = x, Patient = patientToInsert }).ToList();
        patientToInsert.PatientNcd =
            patientDto.Ncds.Select(x => new PatientNCD { NcdId = x, Patient = patientToInsert }).ToList();

        await repository.Insert(patientToInsert);
        await repository.SaveChanges();
    }
}
