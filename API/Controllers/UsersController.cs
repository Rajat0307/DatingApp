using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
       public class UsersController : BaseApiController
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)    //constructor
        {
            _context = context;      // In this class we have access to dataase using _context 
        }
        [HttpGet]   //end point to get all the users
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
           return await _context.Users.ToListAsync(); // making the code async by task, await, async  
              
        }
        [Authorize]
        [HttpGet("{id}")]  //end point to get specific user
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
           return await _context.Users.FindAsync(id);
              
        }
    }
}