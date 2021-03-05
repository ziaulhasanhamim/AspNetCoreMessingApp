using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ChatApp.Application.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Application.Controllers
{
    [Authorize]
    [Route("/api/messages/")]
    public class MessageApiController : ControllerBase
    {
        ApplicationDbContext _dbCtx;

        public MessageApiController(ApplicationDbContext dbCtx)
        {
            _dbCtx = dbCtx;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRelatedToCurrentUser()
        {
            var user = (User)HttpContext.Items["user"];
            var messages = await _dbCtx.Messages
                .Where(m => m.FromId == user.Id || m.ToId == user.Id)
                .Select(m => new
                {
                    Id = m.Id,
                    FromId = m.FromId,
                    ToId = m.ToId,
                    Text = m.Text
                })
                .ToListAsync();            
            return Ok(messages);
        }
    }
}
