using Ecommerce.Application.Repositories;
using Ecommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly AppDbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(AppDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public IEnumerable<T> GetAll() => _dbSet.ToList();
    public T GetById(int id) => _dbSet.Find(id);
    public void Add(T entity) { _dbSet.Add(entity); _context.SaveChanges(); }
    public void Update(T entity) { _dbSet.Update(entity); _context.SaveChanges(); }
    public void Delete(int id) { var entity = _dbSet.Find(id); if (entity != null) _dbSet.Remove(entity); _context.SaveChanges(); }
}