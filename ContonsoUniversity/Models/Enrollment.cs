using ContonsoUniversity.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContonsoUniversity.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }

        public Grade? Grade { get; set; }

        public Course Course { get; set; }

        public Student Student { get; set; }
    }
}
