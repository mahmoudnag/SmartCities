using SmartCities.Core;
using SmartCities.Core.Interfaces;
using SmartCities.EF.Repositories;

namespace SmartCities.EF
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ApplicationDbContext _context;
        private Dictionary<Type, object> _repositories;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            _repositories = new Dictionary<Type, object>();
        }
        public IBaseRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if (_repositories.ContainsKey(typeof(TEntity)))
            {
                return _repositories[typeof(TEntity)] as IBaseRepository<TEntity>;
            }
            var repository = new BaseRepository<TEntity>(_context);
            _repositories.Add(typeof(TEntity), repository);
            return repository;
        }
        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
