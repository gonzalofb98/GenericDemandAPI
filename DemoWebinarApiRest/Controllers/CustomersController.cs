using System.Threading.Tasks;
using AutoMapper;
using Dto.Request;
using Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace DemoWebinarApiRest.Controllers
{
    //[Authorize(AuthenticationSchemes =JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _service;
        
        public CustomersController(ICustomerService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.ListAsync());
        }

        [HttpGet]
        [Route("{id:int}")]

        public async Task<IActionResult> Get(int id)
        {
            var response = await _service.GetByIdAsync(id);

            if (response == null)
                return NotFound();

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DtoCustomerRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _service.CreateAsync(request);

            return Created($"/{response}", new
            {
                Id = response
            });
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Put(int id, DtoCustomerRequest dtoCustomer)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _service.UpdateAsync(id, dtoCustomer);

            return Accepted(new
            {
                Id = response
            });
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);

            return Accepted(new
            {
                Id = id
            });
        }

        [HttpGet]
        [Route("{id:int}/Directions")]
        public async Task<IActionResult> GetDirections(int id)
        {
            return Ok(await _service.GetDirectionsAsync(id));
        }

    }
}