using ESFCustomersData.Data;
using ESFCustomersData.Models;
using ESFCustomersData.Procedures;
using ESFCustomersData.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ESFCustomersData.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;


        public CustomersController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        
        [HttpGet]
        
        public async Task<ActionResult<List<Symvolaia>>> GetCustomers()
        {

            try
            {
                var customers = await _customerRepository.GetCustomers();

                if (customers == null)
                {
                    return NotFound();
                }
                
                var customersDtos = customers.ConvertToDto();

                int count = customersDtos.Value.Count();

                //var test = new JsonResult(new { Items = customersDtos.Value, Count = count });

                return Ok(customersDtos.Value);


            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }
    }
}
