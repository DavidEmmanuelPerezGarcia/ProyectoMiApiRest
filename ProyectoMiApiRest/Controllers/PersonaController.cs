using Microsoft.AspNetCore.Mvc;
using ProyectoMiApiRest.Emtities;
using ProyectoMiApiRest.Repository;


namespace ProyectoMiApiRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonaController : ControllerBase
    {
        /*private readonly ILogger<PersonaController> _logger;*/

        private RepPersona repPersona;

        /* public PersonaController(ILogger<PersonaController> logger)
         {
             _logger = logger;
         }
        */

        public PersonaController()
        {
            repPersona = new RepPersona();
        }

        [HttpGet("Mostrarpersona")]
        public ActionResult MostrarPersona()
        {
            List<ModPersona>? modPerson = new();
            modPerson = repPersona.MostrarPersona();
        
            if(modPerson != null)
            {
                return Ok(modPerson);
            }
            else
            {
                return BadRequest("No se encontraron datos");
            }
        }
    }
}