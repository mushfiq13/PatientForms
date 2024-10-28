using PatientForms.API.Services;
using PatientForms.Domain.Entities.Base;

namespace PatientForms.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class CrudController<TEntity>(ICrudService<TEntity> service) : ControllerBase
    where TEntity : class, IEntity
{
    [HttpGet("get-all")]
    public virtual async Task<IActionResult> GetAll() => Ok(await service.GetAll());

    [HttpDelete("remove")]
    public async Task<IActionResult> Remove(int id)
    {
        await service.Remove(id);

        return NoContent();
    }
}
