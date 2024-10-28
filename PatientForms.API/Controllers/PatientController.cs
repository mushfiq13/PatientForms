using PatientForms.API.Models;
using PatientForms.API.Services;

namespace PatientForms.API.Controllers;

public class PatientController(
    IPatientService patientService,
    ICrudService<Patient> crudService)
    : CrudController<Patient>(crudService)
{
    [HttpGet("get-all")]
    public override async Task<IActionResult> GetAll()
    {
        var patientsToReturn = await patientService.GetAll();

        return Ok(patientsToReturn);
    }

    [HttpPost("insert")]
    public async Task<IActionResult> Insert(PatientBindingModel patientModel)
    {
        await patientService.Insert(patientModel);

        return NoContent();
    }
}
