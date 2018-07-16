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
    public class RiskController : ControllerBase
    {
        private readonly IRiskService _riskService;

        public RiskController(IRiskService riskService)
        {
            _riskService = riskService ?? throw new ArgumentNullException(nameof(riskService));
            _riskService.InitializedMaster();
        }

        [HttpGet(Name = "GetAllRisk")]
        public ActionResult<IEnumerable<Risk>> GetAll()
        {
            return _riskService.GetAll().ToList();
        }

        [HttpGet("{id}", Name = "GetRisk")]
        public ActionResult<Risk> GetById(long id)
        {
            var item = _riskService.GetById(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpPost(Name = "SetRisk")]
        public IActionResult Create([FromBody] Risk item)
        {
            var isCreated = _riskService.Create(item);
            if (!isCreated)
            {
                return NotFound();
            }

            return CreatedAtRoute("GetRisk", new { id = item.Id }, item);
        }

        [HttpPut("{id}", Name = "UpdateRisk")]
        public IActionResult Update(int id, [FromBody] Risk item)
        {
            var isUpdated = _riskService.Update(id, item);
            if (!isUpdated)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteRisk")]
        public IActionResult Delete(long id)
        {
            var isDeleted = _riskService.Delete(id);
            if (!isDeleted)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}