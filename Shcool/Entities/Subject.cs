using System;
namespace Shcool.Entities
{
    public class Subject
    {
        public Subject()
        {
            studentSubjects = new();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<StudentSubject> studentSubjects { get; set; }
    }
}


