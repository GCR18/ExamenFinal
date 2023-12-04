using Microsoft.AspNetCore.Mvc;
using ProyectoBackendGabriel.contexto;
using ProyectoBackendGabriel.modelos;

namespace ProyectoBackendGabriel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlmacenesController : ControllerBase
    {

        private readonly ILogger<AlmacenesController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public AlmacenesController(
            ILogger<AlmacenesController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Almacenes almacenes)
        {
            _aplicacionContexto.Almacenes.Add(almacenes);
            _aplicacionContexto.SaveChanges();
            return Ok(almacenes);
        }
        //READ
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacionContexto.Almacenes.ToList());

        }
        //Update
        [Route("{id}")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] Almacenes almacenes)
        {
            _aplicacionContexto.Almacenes.Update(almacenes);
            _aplicacionContexto.SaveChanges();
            return Ok(almacenes);
        }
        //Delete
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int almacenesId)
        {
            _aplicacionContexto.Almacenes.Remove(
                _aplicacionContexto.Almacenes.ToList()
                .Where(x => x.id_almacen == almacenesId)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(almacenesId);
        }
    }
}
