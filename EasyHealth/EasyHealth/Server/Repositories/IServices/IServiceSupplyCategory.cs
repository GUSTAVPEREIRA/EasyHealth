namespace EasyHealth.Server.Repositories.IServices
{
    using EasyHealth.Shared.Model;
    using System.Linq;

    public interface IServiceSupplyCategory
    {
        IQueryable<SupplyCategory> GetSupplyCategories(string name = "");
        void CreateSupplyCategory(ref SupplyCategory supplyCategory);
        SupplyCategory GetSupplyCategory(int id);
        SupplyCategory UpdateSupplyCategory(ref SupplyCategory supplyCategory);
        void DeleteSupplyCategory(int id);
    }
}
