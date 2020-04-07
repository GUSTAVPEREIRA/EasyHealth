namespace EasyHealth.Client.Utils
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public static class HttpContextExtensions
    {
        public async static Task InsertParameterInPageResponse<T>(this HttpContext context, IQueryable<T> queryable,
            int totalAmountToDisplay)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            double totalAmount = await queryable.CountAsync();
            double totalPages = Math.Ceiling(totalAmount / totalAmountToDisplay);
            context.Response.Headers.Add("totalAmount", totalAmount.ToString());
            context.Response.Headers.Add("totalPages", totalPages.ToString());
        }
    }
}
