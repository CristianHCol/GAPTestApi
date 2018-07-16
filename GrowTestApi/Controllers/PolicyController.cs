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
    public class PolicyController : ControllerBase
    {
        private readonly IPolicyService _policyService;

        public PolicyController(IPolicyService policyService)
        {
            _policyService = policyService ?? throw new ArgumentNullException(nameof(policyService));
        }

        [HttpGet(Name = "GetAllPolicy")]
        public ActionResult<IEnumerable<Policy>> GetAll()
        {
            return _policyService.GetAll().ToList();
        }

        [HttpGet("{id}", Name = "GetPolicy")]
        public ActionResult<Policy> GetById(long id)
        {
            var item = _policyService.GetById(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpPost(Name = "SetPolicy")]
        public IActionResult Create([FromBody] Policy item)
        {
            var isCreated = _policyService.Create(item);
            if (!isCreated)
            {
                return NotFound();
            }

            return CreatedAtRoute("GetPolicy", new { id = item.Id }, item);
        }

        [HttpPut("{id}", Name = "UpdatePolicy")]
        public IActionResult Update(int id, [FromBody] Policy item)
        {
            var isUpdated = _policyService.Update(id, item);
            if (!isUpdated)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeletePolicy")]
        public IActionResult Delete(long id)
        {
            var isDeleted = _policyService.Delete(id);
            if (!isDeleted)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}