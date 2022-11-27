using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shcool.Entities
{
    public class Laptop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }

        [ForeignKey(nameof(student))]
        public int? StudentId { get; set; }
        public Student student { get; set; }

    }
}


