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
    public class AgencyController : ControllerBase
    {
        private readonly IAgencyService _agencyService;

        public AgencyController(IAgencyService agencyService)
        {
            _agencyService = agencyService ?? throw new ArgumentNullException(nameof(agencyService));
            _agencyService.InitializedMaster();
        }

        [HttpGet(Name = "GetAllAgencies")]
        public ActionResult<IEnumerable<Agency>> GetAll()
        {
            return _agencyService.GetAll().ToList();
        }

        [HttpGet("{id}", Name = "GetAgency")]
        public ActionResult<Agency> GetById(long id)
        {
            var item = _agencyService.GetById(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpPost(Name = "SetAgency")]
        public IActionResult Create([FromBody] Agency item)
        {
            var isCreated = _agencyService.Create(item);
            if (!isCreated)
            {
                return NotFound();
            }

            return CreatedAtRoute("GetCoverage", new { id = item.Id }, item);
        }

        [HttpPut("{id}", Name = "UpdateAgency")]
        public IActionResult Update(int id, [FromBody] Agency item)
        {
            var isUpdated = _agencyService.Update(id, item);
            if (!isUpdated)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteAgency")]
        public IActionResult Delete(long id)
        {
            var isDeleted = _agencyService.Delete(id);
            if (!isDeleted)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}