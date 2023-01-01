using FileUpload.ApplicationDbContextModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileUpload.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private ApplicationDbContext _context;
        public UsersController(ApplicationDbContext context) 
        {
            _context = context;
        }

        [HttpGet("Users")]
        public IActionResult GetUsers()
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }
    }
}
