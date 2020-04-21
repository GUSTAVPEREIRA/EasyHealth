namespace EasyHealth.Server.Repositories.Services
{
    using EasyHealth.Shared.Model;
    using System.Linq;
    using EasyHealth.Server.Repositories.IServices;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;

    public class ServiceSupplyCategory : IServiceSupplyCategory
    {

        private readonly ApplicationContext _context;

        public ServiceSupplyCategory(ApplicationContext applicationContext)
        {
            this._context = applicationContext;
        }

        public void CreateSupplyCategory(ref SupplyCategory supplyCategory)
        {
            this._context.SupplyCategories.Add(supplyCategory);
            this._context.SaveChangesAsync();
        }

        public void DeleteSupplyCategory(int id)
        {
            SupplyCategory supplyCategory = this._context.SupplyCategories.FirstOrDefault(w => w.Id == id);
            this._context.SupplyCategories.Remove(supplyCategory);
            this._context.SaveChangesAsync();
        }

        public List<SupplyCategory> GetAllSupplyCategories()
        {
            var result = this._context.SupplyCategories.AsNoTracking().ToList();
            return result;
        }


        public IQueryable<SupplyCategory> GetSupplyCategories(string name = "")
        {
            var queryable = this._context.SupplyCategories.AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                queryable = queryable.Where(w => w.Name.Contains(name));
            }

            return queryable;
        }

        public SupplyCategory GetSupplyCategory(int id)
        {
            return this._context.SupplyCategories.FirstOrDefault(f => f.Id == id);
        }

        public SupplyCategory UpdateSupplyCategory(ref SupplyCategory supplyCategory)
        {
            this._context.Entry(supplyCategory).State = EntityState.Modified;
            this._context.Entry(supplyCategory).Property("LastUpdate").CurrentValue = DateTime.Now;
            this._context.SaveChangesAsync();

            return supplyCategory;
        }
    }
}
