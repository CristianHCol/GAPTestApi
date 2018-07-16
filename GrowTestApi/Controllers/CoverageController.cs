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
    public class CoverageTypesController : ControllerBase
    {
        private readonly ICoverageService _coverageService;

        public CoverageTypesController(ICoverageService coverageService)
        {
            _coverageService = coverageService ?? throw new ArgumentNullException(nameof(coverageService));
            _coverageService.InitializedMaster();
        }

        [HttpGet(Name = "GetAllCoverages")]
        public ActionResult<IEnumerable<CoverageType>> GetAll()
        {
            return _coverageService.GetAll().ToList();
        }

        [HttpGet("{id}", Name = "GetCoverage")]
        public ActionResult<CoverageType> GetById(long id)
        {
            var item = _coverageService.GetById(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpPost(Name = "SetCoverage")]
        public IActionResult Create([FromBody] CoverageType item)
        {
            var isCreated = _coverageService.Create(item);
            if (!isCreated)
            {
                return NotFound();
            }

            return CreatedAtRoute("GetCoverage", new { id = item.Id }, item);
        }

        [HttpPut("{id}", Name = "UpdateCoverage")]
        public IActionResult Update(int id, [FromBody] CoverageType item)
        {
            var isUpdated = _coverageService.Update(id, item);
            if (!isUpdated)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteCoverage")]
        public IActionResult Delete(long id)
        {
            var isDeleted = _coverageService.Delete(id);
            if (!isDeleted)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}