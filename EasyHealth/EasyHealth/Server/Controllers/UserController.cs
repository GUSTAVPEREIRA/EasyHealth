using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyHealth.Shared.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EasyHealth.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public UserController(ApplicationContext applicationContext)
        {
            this._context = applicationContext;
        }

        [HttpPost("{user}", Name = "LoginUser")]
        public async Task<ActionResult<User>> Login(User user)
        {
            return await this._context.Users
                .Where(w => w.Login == user.Login && w.Password == user.Password)
                .FirstOrDefaultAsync();
        }

        [HttpPost("{user}", Name = "CreateUser")]
        public async Task<ActionResult<User>> CreateUser(User user)
        {
            if (this._context.Users.Where(w => w.Login == user.Login).FirstOrDefaultAsync() == null)
            {
                this._context.Users.Add(user);
                await this._context.SaveChangesAsync();
                return new CreatedAtRouteResult("GetUser", new { id = user.Id }, user);
            }

            return null;
        }

        [HttpGet("{id}", Name = "GetUser")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            return await this._context.Users.FirstOrDefaultAsync(f => f.Id == id);
        }

        [HttpPut("{user}", Name = "UpdateUser")]
        public async Task<ActionResult<User>> UpdateUser(User user)
        {
            this._context.Entry(user).State = EntityState.Modified;
            await this._context.SaveChangesAsync();
            return Ok(user);
        }        
    }
}