using System;
using Shcool.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shcool.Dto
{
	public class StudentSubjectDto
	{
		public StudentSubjectDto()
		{
		}
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int SubjectId { get; set; }

        public StudentDto student { get; set; }
        public SubjectDto subject { get; set; }
    }
}

