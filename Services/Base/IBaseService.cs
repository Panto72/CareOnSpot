using CareOnSpot.Models.Base;
using System.Linq.Expressions;

namespace CareOnSpot.Services.Base;

public interface IBaseService<T> where T : BaseEntity, new()
{
    IQueryable<T> GetAll();
    IQueryable<T> GetAll(params Expression<Func<T, Object>>[] includeProperties);
    T Find(int id);
    T Find(int id, params Expression<Func<T, Object>>[] includeProperties);
    void Insert(T entity);
    void Update(T entity, int id);
    void Delete(T entity);


    //Async Methods
    Task<List<T>> GetAllAsync();
    Task<List<T>> GetAllAsync(params Expression<Func<T, Object>>[] includes);
    Task<T?> FindAsync(int id);
    Task<T?> FindAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);

    Task<T> InsertAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<T> UpdateAsync(int id, T entity);
    Task UpdateRangeAsync(List<T> entity);

    Task<T> DeleteAsync(T entity);
    Task DeleteRangeAsync(List<T> entity);

}