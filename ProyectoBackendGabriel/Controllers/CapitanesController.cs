using Microsoft.AspNetCore.Mvc;
using ProyectoBackendGabriel.contexto;
using ProyectoBackendGabriel.modelos;

namespace ProyectoBackendGabriel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CapitanesController : ControllerBase
    {

        private readonly ILogger<CapitanesController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public CapitanesController(
            ILogger<CapitanesController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Capitanes capitanes)
        {
            _aplicacionContexto.Capitanes.Add(capitanes);
            _aplicacionContexto.SaveChanges();
            return Ok(capitanes);
        }
        //READ
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacionContexto.Capitanes.ToList());

        }
        //Update
        [Route("{id}")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] Capitanes capitanes)
        {
            _aplicacionContexto.Capitanes.Update(capitanes);
            _aplicacionContexto.SaveChanges();
            return Ok(capitanes);
        }
        //Delete
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int capitanesId)
        {
            _aplicacionContexto.Capitanes.Remove(
                _aplicacionContexto.Capitanes.ToList()
                .Where(x => x.id_capitan == capitanesId)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(capitanesId);
        }
    }
}
