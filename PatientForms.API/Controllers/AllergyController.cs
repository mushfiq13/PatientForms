using PatientForms.API.Services;

namespace PatientForms.API.Controllers;

public class AllergyController(ICrudService<Allergy> crudService) : CrudController<Allergy>(crudService);