using PatientForms.Domain.Entities.Base;
using PatientForms.EF.Configurations.DataContext;

namespace PatientForms.EF.Repositories.BaseRepository;

public class Repository<TEntity>(AppDbContext ctx) : IRepository<TEntity>
    where TEntity : class, IEntity
{
    private readonly DbSet<TEntity> _entity = ctx.Set<TEntity>();

    public IQueryable<TEntity> GetEntityAsIQueryable() => _entity.AsQueryable();

    public async Task<TEntity?> Get(int id) => await _entity.FindAsync(id);

    public async Task<List<TEntity>> GetAll() => await _entity.ToListAsync();

    public async Task Insert(TEntity entity) => await _entity.AddAsync(entity);

    public async Task Insert(IEnumerable<TEntity> entity) => await _entity.AddRangeAsync(entity);

    public async Task Remove(TEntity entity)
    {
        _entity.Remove(entity);
        
        await Task.CompletedTask;
    }

    public async Task<bool> Any(int id) => await _entity.AnyAsync(x => x.Id.Equals(id));

    public async Task SaveChanges() => await ctx.SaveChangesAsync();
}
