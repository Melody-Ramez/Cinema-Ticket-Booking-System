using Cinema.Application.Services;
using Cinema.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerService customerService;

        public CustomersController(CustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            var customers = customerService.GetAllCustomers();

            return Ok(customers);
        }

        [HttpGet("{customerId}")]
        public IActionResult GetCustomerById([FromRoute] int customerId)
        {
            var customer = customerService.GetCustomerById(customerId);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        [HttpPost]
        public IActionResult AddCustomer([FromBody] Customer customer)
        {
            customerService.AddCustomer(customer);

            return Ok(customer);
        }

        [HttpPut("{customerId}")]
        public IActionResult UpdateCustomer([FromRoute] int customerId,[FromBody] Customer updatedCustomer)
        {
            var customer = customerService.GetCustomerById(customerId);

            if (customer == null)
            {
                return NotFound();
            }

            customerService.UpdateCustomer(customerId, updatedCustomer);

            return Ok(updatedCustomer);
        }

        [HttpDelete("{customerId}")]
        public IActionResult DeleteCustomer([FromRoute] int customerId)
        {
            var customer = customerService.GetCustomerById(customerId);

            if (customer == null)
            {
                return NotFound();
            }

            customerService.DeleteCustomer(customerId);

            return NoContent();
        }
    }
}
