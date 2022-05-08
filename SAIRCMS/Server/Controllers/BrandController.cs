using SAIRCMS.Application.Features.BrandFeatures.Commands;
using SAIRCMS.Application.Features.BrandFeatures.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SAIRCMS.Application;
using SAIRCMS.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SAIRCMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : BaseController
    {
        //private IMediator Mediator;
        //public BrandController(IMediator mediator)
        //{
        //    Mediator = mediator;
        //}
        // GET: api/<BrandController>
        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get()
        {
            var result = await Mediator.Send(new GetAllBrandQuery());
            if (!result.IsSuccess)
            {
                return StatusCode(500, result.FailureMessage);
            }
            return Ok(result);
        }

        // GET api/<BrandController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await Mediator.Send(new GetByIdBrandQuery(id)));
        }

        // POST api/<BrandController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Brand brand)
        {
            var result = await Mediator.Send(new AddBrandCommand(brand));
            return Ok(result);
        }

        // PUT api/<BrandController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BrandController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
