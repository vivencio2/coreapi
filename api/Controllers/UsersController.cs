using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        // GET: api/Users
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return new List<User>()
            {
                new User { FirstName = "John", LastName = "Doe", Role = Role.Employee },
                new User { FirstName = "Jane", LastName = "Doe", Role = Role.Employee },
                new User { FirstName = "Juan", LastName = "Dela Cruz", Role = Role.Employee },
                new User { FirstName = "Gabriela", LastName = "Dela Cruz", Role = Role.Employee },
                new User { FirstName = "Other", LastName = "Doe", Role = Role.Employee },
                new User { FirstName = "Joan", LastName = "Doe", Role = Role.Employee },
                new User { FirstName = "Every", LastName = "Juan", Role = Role.Employee },
                new User { FirstName = "Dos", LastName = "Cruz", Role = Role.Manager },
                new User { FirstName = "Tres", LastName = "Cruz", Role = Role.Employee },
                new User { FirstName = "Kwatro", LastName = "Doe", Role = Role.Manager },
                new User { FirstName = "Singko", LastName = "Manila", Role = Role.Employee },
                new User { FirstName = "Sais", LastName = "Dela Rosa", Role = Role.Employee },
                new User { FirstName = "Siete", LastName = "Diretso", Role = Role.Employee },
            };
        }

        // GET: api/Users/5
        [HttpGet("{id}", Name = "Get")]
        public User Get(int id)
        {
            return new User { FirstName = "John", LastName = "Doe", Role = Role.Employee };
        }

        // POST: api/Users
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
