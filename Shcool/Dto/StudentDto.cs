using System;
using Shcool.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shcool.Dto
{
	public class StudentDto
	{
		public StudentDto()
		{
            studentSubjects = new();

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int SchoolId { get; set; }


        public LaptopDto? laptop { get; set; }

        
        public SchoolDto? school { get; set; }

        public List<StudentSubjectDto>? studentSubjects { get; set; }
    }
}

