using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shcool.Dto;
using Shcool.Entities;

namespace Shcool.Controllers
{
	[ApiController]
    [Route("[controller]")]
    public class StudentController:ControllerBase
	{
        private readonly SchoolDbContext _db;

        public StudentController(SchoolDbContext db)
		{
            _db = db;
        }

        [HttpPost]
        public ActionResult post(StudentDto studentDto)
        {
            if (studentDto == null) return BadRequest();
            Student student = new()
            {
                Name = studentDto.Name,
                Age = studentDto.Age,
                SchoolId = studentDto.SchoolId
            };

            _db.Students.Add(student);

            try
            {
                _db.SaveChanges();
                return Ok(student);
            }
            catch(Exception ex)
            {
                return Problem(ex.ToString());
            }
            
        }

        [HttpGet]
        public ActionResult get()
        {
            var students = _db.Students.Where(s=>s.Id==2).ToList();
            if (students.Count == 0) return NotFound();
            return Ok(students);
        }
	}
}

