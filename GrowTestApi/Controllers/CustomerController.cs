using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using GrowTestApi.Model;
using GrowTestApi.Services;

namespace GrowTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
        }

        [HttpGet(Name = "GetAllCustomer")]
        public ActionResult<IEnumerable<Customer>> GetAll()
        {
            return _customerService.GetAll().ToList();
        }

        [HttpGet("{id}", Name = "GetCustomer")]
        public ActionResult<Customer> GetById(long id)
        {
            var item = _customerService.GetById(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpPost(Name = "SetCustomer")]
        public IActionResult Create([FromBody] Customer item)
        {
            var isCreated = _customerService.Create(item);
            if (!isCreated)
            {
                return NotFound();
            }

            return CreatedAtRoute("GetCustomer", new { id = item.Id }, item);
        }

        [HttpPut("{id}", Name = "UpdateCustomer")]
        public IActionResult Update(int id, [FromBody] Customer item)
        {
            var isUpdated = _customerService.Update(id, item);
            if (!isUpdated)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteCustomer")]
        public IActionResult Delete(long id)
        {
            var isDeleted = _customerService.Delete(id);
            if (!isDeleted)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}