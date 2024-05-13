using CareOnSpot.DBConncetion;
using CareOnSpot.Models.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Reflection;

namespace CareOnSpot.Services.Base;

public class BaseService<T> : IBaseService<T> where T : BaseEntity, new()
{
    private readonly AppDbContext _context;
    private readonly DbSet<T> entities;

    public BaseService(AppDbContext context)
    {
        _context = context;
        entities = _context.Set<T>();
    }

    public IQueryable<T> GetAll()
    {
        return entities;
    }

    public IQueryable<T> GetAll(params Expression<Func<T, Object>>[] includeProperties)
    {
        IQueryable<T> queryable = GetAll();
        foreach (Expression<Func<T, object>> includeProperty in includeProperties)
        { queryable = queryable.Include<T, object>(includeProperty); }
        return queryable;
    }

    public T Find(int id)
    {
        return entities.FirstOrDefault(s => s.Id == id)!;
    }

    public T Find(int id, params Expression<Func<T, object>>[] includeProperties)
    {
        IQueryable<T> query = _context.Set<T>();
        foreach (var includeProperty in includeProperties)
        {
            query = query.Include(includeProperty);
        }
        return query.FirstOrDefault(x => x.Id == id)!;
    }

    public void Insert(T entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
        entity.CreatedDate = DateTime.UtcNow;
        entity.UpdateDate = DateTime.UtcNow;
        entities.Add(entity);
        _context.SaveChanges();
    }

    public void Update(T entity, int id)
    {
        ArgumentNullException.ThrowIfNull(entity);
        T? exist = _context.Set<T>().Find(id);
        if (exist != null)
        {
            _context.Entry(exist).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }
        _context.SaveChanges();
    }

    public void Delete(T entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
        entities.Remove(entity);
        _context.SaveChanges();
    }


    //Async Methods

    public async Task<List<T>> GetAllAsync()
    {
        return await entities.ToListAsync();
    }
    public async Task<List<T>> GetAllAsync(params Expression<Func<T, Object>>[] includeProperties)
    {
        return await includeProperties.Aggregate(entities.AsQueryable(),
            (current, include) => current.Include(include)).ToListAsync();
    }

    public async Task<T?> FindAsync(int id)
    {
        return await entities!.FindAsync(id).ConfigureAwait(false);
    }

    public async Task<T?> FindAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
    {
        return await includeProperties.Aggregate(entities!.AsQueryable(),
        (current, include) => current.Include(include),
        c => c.AsNoTracking().FirstOrDefaultAsync(predicate)
    ).ConfigureAwait(false);
    }

    public async Task<T> UpdateAsync(T entity)
    {
        entities.Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
    public async Task<T> UpdateAsync(int id, T entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
        T? exist = _context.Set<T>().Find(id);
        if (exist != null)
        {
            _context.Entry(exist).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();
        }
        await _context.SaveChangesAsync();

        return entity;
    }

    public virtual async Task UpdateRangeAsync(List<T> entity)
    {
        entities.UpdateRange(entity);
        await Task.CompletedTask;
    }

    public async Task<T> DeleteAsync(T entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
        entities.Remove(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public virtual async Task DeleteRangeAsync(List<T> entity)
    {
        entities.RemoveRange(entity);
        await Task.CompletedTask;
    }
    public async Task<T> InsertAsync(T entity)
    {
        await entities.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

}
