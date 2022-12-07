using System;
using Microsoft.AspNetCore.Mvc;
using Shcool.Entities;

namespace Shcool.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SchoolController:ControllerBase
	{
		private readonly SchoolDbContext _db;
		public SchoolController(SchoolDbContext db)
		{
			_db = db;
		}

		[HttpPost]
		public IActionResult post([FromBody]School school)
		{
			if (school == null)
			{
				return BadRequest();
			}
			_db.Schools.Add(school);
			try
			{
                _db.SaveChanges();
				return Ok(school);
            }
			catch(Exception ex)
			{
				return Problem(ex.ToString());
			}
			
		}


		[HttpGet]
		public IActionResult get()
		{
			var schools = _db.Schools.ToList();
			if (!(schools.Count > 0))
			{
				return NotFound();
			}

			return Ok(schools);
		}

		[HttpGet("[action]")]
		public IActionResult getById([FromQuery]int id)
		{
			if (id == 0) return BadRequest();
			var school = _db.Schools.Find(id);
			if (school == null) return NotFound();
			return Ok(school);
		}
		[HttpPut]
		public IActionResult put([FromBody]School school)
		{
			if (school == null) return BadRequest();
			var oldSchool = _db.Schools.Find(school.Id);
			if (oldSchool == null) return NotFound();
			oldSchool.Name = school.Name;
			oldSchool.Location = school.Location;

			try
			{
				_db.SaveChanges();
				return Ok(school);
			}
			catch(Exception ex)
			{
				return Problem(ex.ToString());
			}
		}

		[HttpDelete]
		public IActionResult delete([FromQuery]int id)
		{
			if (id == 0) return BadRequest();
			var school = _db.Schools.Find(id);
			if (school == null) return NotFound();
			_db.Schools.Remove(school);
			try
			{
				_db.SaveChanges();
				return Ok("deleted");
			}catch(Exception ex)
			{
				return Problem(ex.ToString());
			}
		}
	}
}

