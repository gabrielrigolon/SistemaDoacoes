using Microsoft.AspNetCore.Mvc;
using SistemaDoacoes.Core.Aggregates.AuthAgg.Entities;
using SistemaDoacoes.Core.Aggregates.AuthAgg.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDoacoes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssistedInstitutionController : ControllerBase
    {
        private readonly IAssistedInstitutionService _assistedInstitutionService;

        public AssistedInstitutionController(IAssistedInstitutionService assistedInstitutionService)
        {
            _assistedInstitutionService = assistedInstitutionService;
        }


        // GET: api/AssistedInstitution
        [HttpGet]
        public ActionResult<IEnumerable<AssistedInstitution>> Get()
        {
            try
            {
                return Ok(_assistedInstitutionService.GetAssistedInstitutions());
            }
            catch (Exception exception)
            {
                return BadRequest(exception);
            }
        }


        // GET: api/AssistedInstitution/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_assistedInstitutionService.GetAssistedInstitution(id));
            }
            catch (Exception exception)
            {
                return BadRequest(exception);
            }
        }

        // POST: api/AssistedInstitution
        [HttpPost]
        public IActionResult RegisterAssistedInstitution([FromBody] AssistedInstitution assistedInstitution)
        {
            try
            {
                return Created("assistedInstitutions", _assistedInstitutionService.CreateAssistedInstitution(assistedInstitution));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // PUT: api/AssistedInstitution/5
        [HttpPut]
        public IActionResult EditAssistedInstitution([FromBody] AssistedInstitution assistedInstitution)
        {
            try
            {
                return Ok(_assistedInstitutionService.UpdateAssistedInstitution(assistedInstitution));
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{idAssistedInstitution}")]
        public IActionResult DeleteAssistedInstitutions(int idAssistedInstitution)
        {
            try
            {
                _assistedInstitutionService.DeleteAssistedInstitution(idAssistedInstitution);
                return Ok(new { Sucess = true, Message = "Deletado com sucesso" });
            }
            catch (Exception exception)
            {

                return BadRequest(exception);
            }
        }
    }
}
