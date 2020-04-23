namespace EasyHealth.Server.Repositories.Services
{
    using EasyHealth.Server.Repositories.IServices;
    using EasyHealth.Shared.Model;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ServiceHospitalSupply : IServiceHospitalSupply
    {
        private readonly ApplicationContext _context;

        public ServiceHospitalSupply(ApplicationContext applicationContext)
        {
            this._context = applicationContext;
        }

        public void CreateHospitalSupply(ref HospitalSupply hospitalSupply)
        {           
            this._context.Add(hospitalSupply);
            this._context.SaveChangesAsync();
        }

        public HospitalSupply UpdateHospitalSupply(ref HospitalSupply hospitalSupply)
        {
            this._context.Entry(hospitalSupply).State = EntityState.Modified;
            this._context.Entry(hospitalSupply).Property("LastUpdate").CurrentValue = DateTime.Now;
            this._context.SaveChangesAsync();

            return hospitalSupply;
        }

        public void DeleteHospitalSupply(int id)
        {
            HospitalSupply hospitalSupply = this._context.HospitalSupplies.FirstOrDefault(f => f.Id == id);
            this._context.HospitalSupplies.Remove(hospitalSupply);
            this._context.SaveChangesAsync();
        }

        public HospitalSupply GetHospitalSupply(int id)
        {
            return this._context.HospitalSupplies.Include(i => i.SupplyCategory).FirstOrDefault(f => f.Id == id);
        }


        public List<HospitalSupply> GetAllHospitalSupply()
        {
            return this._context.HospitalSupplies.Include(i => i.SupplyCategory).ToList();
        }

        public IQueryable<HospitalSupply> GetHospitalSupplies(string name = "")
        {
            var queryable = this._context.HospitalSupplies.Include(i => i.SupplyCategory).AsQueryable();
           
            if (!string.IsNullOrEmpty(name))
            {
                queryable = queryable.Where(w => w.Name.Contains(name) || w.SupplyCategory.Name.Contains(name));
            }

            return queryable;
        }
    }
}
