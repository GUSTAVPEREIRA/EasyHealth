namespace EasyHealth.Server.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using EasyHealth.Shared.Model;
    using EasyHealth.Shared.Resources;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using EasyHealth.Shared.Utils;

    [Route("api/[controller]")]
    [ApiController]
    public class SupplyCategoryController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public SupplyCategoryController(ApplicationContext applicationContext)
        {
            this._context = applicationContext;
        }

        [HttpGet("Get", Name = "GetSupplyCategories")]
        public async Task<ActionResult<List<SupplyCategory>>> GetSupplyCategory([FromQuery] Pagination pagination)
        {
            var queryable = this._context.SupplyCategories.AsQueryable();
            await HttpContext.InsertParameterInPageResponse(queryable, pagination.Amount);
            return await queryable.Pagination(pagination).ToListAsync();
        }

        [HttpPost("Add", Name = "AddSupplyCategory")]
        public async Task<ActionResult<SupplyCategory>> CreateSupplyCategory(SupplyCategory supplyCategory)
        {
            this._context.SupplyCategories.Add(supplyCategory);
            await this._context.SaveChangesAsync();
            return new CreatedAtRouteResult("GetSupplyCategory", new { id = supplyCategory.Id }, supplyCategory);

        }

        [HttpGet("Get/{id}", Name = "GetSupplyCategory")]
        public async Task<ActionResult<SupplyCategory>> GetSupplyCategory(int id)
        {
            return await this._context.SupplyCategories.FirstOrDefaultAsync(f => f.Id == id);
        }

        [HttpPut("Update", Name = "UpdateSupplyCategory")]
        public async Task<ActionResult<SupplyCategory>> UpdateSupplyCategory(SupplyCategory supplyCategory)
        {
            this._context.Entry(supplyCategory).State = EntityState.Modified;
            await this._context.SaveChangesAsync();
            return Ok(supplyCategory);
        }

        [HttpDelete("Delete/{id}", Name = "DeleteSupplyCategory")]
        public async Task DeleteSupplyCategory(int id)
        {
            SupplyCategory supplyCategory = await this._context.SupplyCategories.FirstOrDefaultAsync(w => w.Id == id);
            this._context.SupplyCategories.Remove(supplyCategory);
            await this._context.SaveChangesAsync();
        }

    }
}