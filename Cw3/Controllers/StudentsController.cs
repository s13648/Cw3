using Microsoft.AspNetCore.Mvc;

namespace Cw3.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GeStudents(int id)
        {
            if (id == 1)
            {
                return Ok("Kowalski");
            }
            else if(id == 2)
            {
                return Ok("Malewski");
            }

            return NotFound("Nie znaleziono studenta");
        }
    }
}
