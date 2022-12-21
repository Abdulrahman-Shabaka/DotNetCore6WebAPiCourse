using System;
using Shcool.Entities;

namespace Shcool.Dto
{
	public class SchoolDto
	{
		public SchoolDto()
		{
            students = new();

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public List<StudentDto>? students { get; set; }
    }
}

