namespace EasyHealth.Shared.Utils
{
    using EasyHealth.Shared.Resources;
    using System.Linq;

    public static class QueryableExtensions
    {
        public static IQueryable<T> Pagination<T>(this IQueryable<T> queryable, Pagination pagination)
        {            
            return queryable.Skip((pagination.Page - 1) * pagination.Amount)
                .Take(pagination.Amount);
        }
    }
}
