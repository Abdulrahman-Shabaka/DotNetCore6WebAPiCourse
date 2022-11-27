using System;
namespace Shcool.Entities
{
    public class School
    {
        public School()
        {
            students = new();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public List<Student> students { get; set; }
    }
}


