using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shcool.Entities
{
	public class StudentSubject
	{
		public int Id { get; set; }

		[ForeignKey(nameof(student))]
		public int StudentId { get; set; }

        [ForeignKey(nameof(subject))]
        public int  SubjectId { get; set; }

		public Student student { get; set; }
		public Subject subject { get; set; }
	}
}

