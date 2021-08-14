using DataAccesLayer.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public interface IDbRepository
    {
        Task<T> Add<T>(T newEntity) where T : class, IEntity;
        IQueryable<T> Get<T>() where T : class, IEntity;
        Task Update<T>(T entity) where T : class, IEntity;
        Task Delete<T>(T entity) where T : class, IEntity;
        Task<int> SaveChangesAsync();
    }
}