using Microsoft.AspNetCore.Mvc;
using SAIRCMS.Application;
using SAIRCMS.Domain.Entities;
using System;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SAIRCMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : BaseController
    {
        // GET: api/<CategoryController>
        [HttpGet]
        [Route("getall")]
        
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new GetAllCategoryQuery()));
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await Mediator.Send(new GetCategoryByIdQuery(id)));
        }

        // POST api/<CategoryController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Category category)
        {
            try
            {
                var result = await Mediator.Send(new AddCategoryCommand(category));
                if (result.IsSuccess)
                {
                    return Ok(result);
                }
                else
                {
                    return StatusCode(500, result.FailureMessage);
                }

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
