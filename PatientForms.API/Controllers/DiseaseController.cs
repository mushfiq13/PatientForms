using PatientForms.API.Services;

namespace PatientForms.API.Controllers;

public class DiseaseController(ICrudService<Disease> crudService) : CrudController<Disease>(crudService);

