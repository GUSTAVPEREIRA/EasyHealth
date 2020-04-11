namespace EasyHealth.Server.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using EasyHealth.Shared.Model;
    using EasyHealth.Shared.Resources;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using EasyHealth.Shared.Utils;
    using EasyHealth.Server.Repositories.IServices;

    [Route("api/[controller]")]
    [ApiController]
    public class SupplyCategoryController : ControllerBase
    {
        private readonly IServiceSupplyCategory _serviceSupplyCategory;

        public SupplyCategoryController(IServiceSupplyCategory serviceSupplyCategory)
        {
            this._serviceSupplyCategory = serviceSupplyCategory;
        }

        [HttpGet("Get", Name = "GetSupplyCategories")]
        public async Task<ActionResult<List<SupplyCategory>>> GetSupplyCategory([FromQuery] Pagination pagination,
            [FromQuery] string name)
        {
            var queryable = this._serviceSupplyCategory.GetSupplyCategories(name);
            await HttpContext.InsertParameterInPageResponse(queryable, pagination.Amount);
            return await queryable.Pagination(pagination).ToListAsync();
        }

        [HttpPost("Add", Name = "AddSupplyCategory")]
        public ActionResult<SupplyCategory> CreateSupplyCategory(SupplyCategory supplyCategory)
        {
            this._serviceSupplyCategory.CreateSupplyCategory(ref supplyCategory);
            return new CreatedAtRouteResult("GetSupplyCategory", new { id = supplyCategory.Id }, supplyCategory);
        }

        [HttpGet("Get/{id}", Name = "GetSupplyCategory")]
        public ActionResult<SupplyCategory> GetSupplyCategory(int id)
        {
            return this._serviceSupplyCategory.GetSupplyCategory(id);
        }

        [HttpPut("Update", Name = "UpdateSupplyCategory")]
        public ActionResult<SupplyCategory> UpdateSupplyCategory(SupplyCategory supplyCategory)
        {
            this._serviceSupplyCategory.UpdateSupplyCategory(ref supplyCategory);
            return Ok(supplyCategory);
        }

        [HttpDelete("Delete/{id}", Name = "DeleteSupplyCategory")]
        public void DeleteSupplyCategory(int id)
        {
            this._serviceSupplyCategory.DeleteSupplyCategory(id);
        }

    }
}