using Microsoft.AspNetCore.Mvc;
using Psi.Eliane.Core.Domain.Entities;

namespace Psi.Prontuarios.Api
{
    public class PacienteController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public IActionResult Post([FromBody] Paciente request)
        {
            return Created("","Success Created!");
        }
        
        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public IActionResult Put(Guid id, [FromBody] Paciente request)
        {
            return Ok("Success updated");
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public IActionResult Delete(Guid id)
        {
            return Ok("Success Deleted");
        }

        [HttpGet("{id:guid?}")]
        [ProducesResponseType(typeof(List<Paciente>), 200)]
        [ProducesResponseType(typeof(Paciente), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public IActionResult Get([FromRoute]Guid? id)
        {
            return Ok();
        }       
    }
}
