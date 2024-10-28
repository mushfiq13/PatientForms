using PatientForms.Domain.Entities.Base;
using PatientForms.EF.Repositories.BaseRepository;

namespace PatientForms.API.Services;

public class CrudService<TEntity>(IRepository<TEntity> repository) : ICrudService<TEntity>
    where TEntity : class, IEntity
{
    public async Task<TEntity?> Get(int id) => await repository.Get(id);

    public async Task<List<TEntity>> GetAll() => await repository.GetAll();

    public async Task Remove(int id)
    {
        var entity = await repository.Get(id);
        if (entity == null)
        {
            throw new InvalidOperationException();
        }

        await repository.Remove(entity);
        await repository.SaveChanges();
    }
}