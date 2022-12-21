using System;
using Shcool.Entities;

namespace Shcool.Dto
{
	public class SubjectDto
	{
		public SubjectDto()
		{
            studentSubjects = new();

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<StudentSubjectDto> studentSubjects { get; set; }
    }
}

