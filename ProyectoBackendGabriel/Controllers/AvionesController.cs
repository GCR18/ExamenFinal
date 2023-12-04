using Microsoft.AspNetCore.Mvc;
using ProyectoBackendGabriel.contexto;
using ProyectoBackendGabriel.modelos;

namespace ProyectoBackendGabriel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AvionesController : ControllerBase
    {

        private readonly ILogger<AvionesController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public AvionesController(
            ILogger<AvionesController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Aviones aviones)
        {
            _aplicacionContexto.Aviones.Add(aviones);
            _aplicacionContexto.SaveChanges();
            return Ok(aviones);
        }
        //READ
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacionContexto.Aviones.ToList());

        }
        //Update
        [Route("{id}")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] Aviones aviones)
        {
            _aplicacionContexto.Aviones.Update(aviones);
            _aplicacionContexto.SaveChanges();
            return Ok(aviones);
        }
        //Delete
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int avionesId)
        {
            _aplicacionContexto.Aviones.Remove(
                _aplicacionContexto.Aviones.ToList()
                .Where(x => x.id_avion == avionesId)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(avionesId);
        }
    }
}
