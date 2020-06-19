using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DatingApp.API.Data;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly DataContext context;

        public ValuesController(DataContext _context)
        {
             context=_context;
        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult>  GetValues()
        { 
            var result=await context.Val.ToListAsync();
            return Ok(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult>   GetValue(int id)
        {
           var result=await context.Val.FirstOrDefaultAsync(x=>x.Id.Equals(id));
           return Ok(result);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
