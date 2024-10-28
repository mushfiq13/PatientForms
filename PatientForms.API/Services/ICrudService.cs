using PatientForms.Domain.Entities.Base;

namespace PatientForms.API.Services;

public interface ICrudService<TEntity> where TEntity : class, IEntity
{
    Task<TEntity?> Get(int id);
    Task<List<TEntity>> GetAll();
    Task Remove(int id);
}