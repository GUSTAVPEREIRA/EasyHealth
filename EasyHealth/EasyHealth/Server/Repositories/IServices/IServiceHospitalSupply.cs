namespace EasyHealth.Server.Repositories.IServices
{
    using EasyHealth.Shared.Model;
    using System.Linq;

    public interface IServiceHospitalSupply
    {
        void CreateHospitalSupply(ref HospitalSupply hospitalSupply);
        HospitalSupply UpdateHospitalSupply(ref HospitalSupply hospitalSupply);
        void DeleteHospitalSupply(int id);
        HospitalSupply GetHospitalSupply(int id);
        IQueryable<HospitalSupply> GetHospitalSupplies(string name = "");        
    }
}
