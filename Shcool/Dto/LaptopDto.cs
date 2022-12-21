using System;
using Shcool.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shcool.Dto
{
	public class LaptopDto
	{
		
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }

        public int? StudentId { get; set; }
        public StudentDto? student { get; set; }
    }
}

