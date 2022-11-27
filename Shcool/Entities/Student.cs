using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shcool.Entities
{
    public class Student
    {
        public Student()
        {
            studentSubjects = new();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Laptop laptop { get; set; }

        [ForeignKey(nameof(school))]
        public int SchoolId { get; set; }
        public School school { get; set; }

        public List<StudentSubject> studentSubjects { get; set; }
    }
}


