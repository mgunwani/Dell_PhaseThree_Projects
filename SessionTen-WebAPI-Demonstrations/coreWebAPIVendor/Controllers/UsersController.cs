using coreWebAPIVendor.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coreWebAPIVendor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicyOrigin")]
    public class UsersController : ControllerBase
    {
        public ApplicationDBContext context;

        public UsersController(ApplicationDBContext _context)
        {
            context = _context;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            var users = context.Users.ToList();
            return Ok(users);
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            var user = context.Users.Find(id);
            if (user == null)
                return NotFound();
            return user;
        }

        // POST api/<UsersController>
        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return Created("Get", new { id = user.UserId });
        }

        // PUT api/<UsersController>/5
        [HttpPut]
        public ActionResult Put([FromBody] User user)
        {
            if (user == null)
                return BadRequest();
            context.Users.Update(user);
            context.SaveChanges();
            return Ok();
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var user = context.Users.Find(id);
            if (user == null)
                return NotFound();
            context.Users.Remove(user);
            context.SaveChanges();
            return Ok();
        }
    }
}
