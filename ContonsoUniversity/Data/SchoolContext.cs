using ContonsoUniversity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContonsoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext (DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        // See on selleks, et andmebaasis oleks tabelite nimed ainsuses
        protected override void OnModelCreating (ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Course>().ToTable("Course");
            modelbuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelbuilder.Entity<Student>().ToTable("Student");
        }
    }
}
