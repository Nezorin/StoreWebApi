using DataAccesLayer.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class DbRepository : IDbRepository
    {
        private readonly DataContext _context;

        public DbRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<T> Add<T>(T newEntity) where T : class, IEntity
        {
            var entity = await _context.Set<T>().AddAsync(newEntity);
            return entity.Entity;
        }
        public IQueryable<T> Get<T>() where T : class, IEntity
        {
            return _context.Set<T>().AsQueryable();
        }
        public async Task Update<T>(T entity) where T : class, IEntity
        {
            await Task.Run(() => _context.Set<T>().Update(entity));
        }
        public async Task Delete<T>(T Entity) where T : class, IEntity
        {
            await Task.Run(() => _context.Set<T>().Remove(Entity));
        }
        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

    }
}

