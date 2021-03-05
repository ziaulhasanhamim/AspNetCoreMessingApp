using ChatApp.Application.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Application.Controllers
{
    [Route("api/user/")]
    public class UserApiController : Controller
    {
        ApplicationDbContext _context;

        public UserApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllUsers()
        {
            var user = (User)HttpContext.Items["user"];
            return Ok(await _context.Users.Where(u => u.Id != user.Id).ToListAsync());
        }
    }
}
