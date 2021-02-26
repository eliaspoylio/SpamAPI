using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpamAPI.Models;

namespace SpamAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly SpamDbContext _context;

        public MessagesController(SpamDbContext context)
        {
            _context = context;
        }

        // GET: api/Messages
        [EnableCors("AllowOrigin")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Message>>> GetMessage()
        {
            return await _context.Message.ToListAsync();
        }

        // GET: api/Messages/5
        [EnableCors("AllowOrigin")]
        [HttpGet("{id}")]
        public async Task<ActionResult<Message>> GetMessage(int id)
        {
            var message = await _context.Message.FindAsync(id);

            if (message == null)
            {
                return NotFound();
            }

            return message;
        }


    }

}
