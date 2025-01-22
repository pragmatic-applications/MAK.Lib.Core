namespace Interfaces;

public interface IPagedList<T> where T : class
{
    Task<DataResult<PagedList<T>>> GetPagedList(PagingEntity entityParameter, string categoryUrl = null);
}
