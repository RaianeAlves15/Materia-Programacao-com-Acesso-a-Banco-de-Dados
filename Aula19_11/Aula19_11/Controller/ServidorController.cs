using Microsoft.AspNetCore.Mvc;

namespace Aula19_11.Controller
{
    [ApiController]
    [Route("Servidores")]
    public class ServidorController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpGet] ("{id}")
        public IActionResult GetById(int id)
        {

        }



       
    }
}
