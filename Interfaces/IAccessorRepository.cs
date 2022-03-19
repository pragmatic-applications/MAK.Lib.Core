namespace Interfaces;

public interface IAccessorRepository<TEntity, TEntityID> where TEntity : class where TEntityID : struct
{
    IQueryable<TEntity> Get();
    IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);

    Task<DataResult<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate);
    Task<DataResult<IEnumerable<TEntity>>> GetAsync();
    Task<DataResult<ICollection<TEntity>>> GetOrderByAsync();
    Task<DataResult<ICollection<TEntity>>> GetOrderByDescendingAsync();
    Task<DataResult<TEntity>> FindAsync(TEntityID id);

    Task<bool> SuccessAsync(TEntityID id);
    Task<bool> SuccessAsync(Expression<Func<TEntity, bool>> predicate);
}

//// Orig
//public interface IAccessorRepository<TEntity, TEntityID> where TEntity : class where TEntityID : struct
//{
//    IQueryable<TEntity> Get();

//    IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);

//    Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);

//    Task<IEnumerable<TEntity>> GetAsync();

//    Task<ICollection<TEntity>> GetOrderByAsync();

//    Task<ICollection<TEntity>> GetOrderByDescendingAsync();

//    //// Orig
//    //Task<TEntity> FindAsync(TEntityID id);
//    Task<DataResult<TEntity>> FindAsync(TEntityID id);

//    Task<bool> SuccessAsync(TEntityID id);

//    Task<bool> SuccessAsync(Expression<Func<TEntity, bool>> predicate);
//}
