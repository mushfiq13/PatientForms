using PatientForms.Domain.Entities.Base;

namespace PatientForms.EF.Repositories.BaseRepository;

public interface IRepository<TEntity>
    where TEntity : class, IEntity
{
    IQueryable<TEntity> GetEntityAsIQueryable();
    Task<TEntity?> Get(int id);
    Task<List<TEntity>> GetAll();
    Task Insert(TEntity entity);
    Task Insert(IEnumerable<TEntity> entity);
    Task Remove(TEntity entity);
    Task<bool> Any(int id);
    Task SaveChanges();
}