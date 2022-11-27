using System;
using Microsoft.EntityFrameworkCore;
using Shcool.Entities;

namespace Shcool
{
	public class SchoolDbContext:DbContext
	{
		public SchoolDbContext(DbContextOptions options):base(options){}

		public DbSet<Laptop> Laptops { get; set; }
		public DbSet<School> Schools { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<Subject> Subjects { get; set; }
		public DbSet<StudentSubject> StudentSubjects { get; set; }
	}
}

