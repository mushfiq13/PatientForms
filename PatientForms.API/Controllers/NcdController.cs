using PatientForms.API.Services;

namespace PatientForms.API.Controllers;

public class NcdController(ICrudService<NCD> crudService) : CrudController<NCD>(crudService);
