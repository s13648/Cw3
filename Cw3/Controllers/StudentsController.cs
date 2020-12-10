using System;
using Cw3.Models;
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

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"{new Random().Next(1, 20000)}";
            return Ok(student);
        }
    }
}
