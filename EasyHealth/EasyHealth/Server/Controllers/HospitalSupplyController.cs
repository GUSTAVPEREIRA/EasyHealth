namespace EasyHealth.Server.Controllers
{
    using EasyHealth.Server.Repositories.IServices;
    using EasyHealth.Shared.Model;
    using EasyHealth.Shared.Utils;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using EasyHealth.Shared.Resources;
    using Microsoft.EntityFrameworkCore;

    [Route("api/[controller]")]
    [ApiController]    
    public class HospitalSupplyController : ControllerBase
    {
        private readonly IServiceHospitalSupply _serviceHospitalSupply;

        public HospitalSupplyController(IServiceHospitalSupply serviceHospitalSupply)
        {
            this._serviceHospitalSupply = serviceHospitalSupply;
        }

        [HttpGet("Get/{id}", Name = "GetHospitalSupply")]
        public ActionResult<HospitalSupply> GetSupplyCategory(int id)
        {
            return this._serviceHospitalSupply.GetHospitalSupply(id);
        }

        [HttpGet("Get", Name = "GetHospitalSupplies")]
        public async Task<ActionResult<List<HospitalSupply>>> GetSupplyCategory([FromQuery] Pagination pagination,
            [FromQuery] string name)
        {
            var queryable = this._serviceHospitalSupply.GetHospitalSupplies(name);
            await HttpContext.InsertParameterInPageResponse(queryable, pagination.Amount);
            return await queryable.Pagination(pagination).ToListAsync();
        }

        [HttpPost("Add", Name = "AddHospitalSupply")]
        public ActionResult<HospitalSupply> CreateSupplyCategory(HospitalSupply hospitalSupply)
        {
            this._serviceHospitalSupply.CreateHospitalSupply(ref hospitalSupply);
            return new CreatedAtRouteResult("GetHospitalSupply", new { id = hospitalSupply.Id }, hospitalSupply);
        }

        [HttpPut("Update", Name = "UpdateHospitalSupply")]
        public ActionResult<HospitalSupply> UpdateHospitalSupply(HospitalSupply hospitalSupply)
        {
            this._serviceHospitalSupply.UpdateHospitalSupply(ref hospitalSupply);
            return Ok(hospitalSupply);
        }

        [HttpDelete("Delete/{id}", Name = "DeleteHospitalSupply")]
        public void DeleteHospitalSupply(int id)
        {
            this._serviceHospitalSupply.DeleteHospitalSupply(id);
        }
    }
}