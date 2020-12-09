using Microsoft.AspNetCore.Mvc;

namespace Cw3.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GeStudents(string orderBy)
        {
            return Ok($"Kowalski, Malewski, Andrzejewski sortowanie = {orderBy}");
        }
    }
}
