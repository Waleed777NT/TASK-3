using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK3
{
    public class Enrollment
    {
        public int Id { get; set; }

        public Student Student { get; set; }

        public int StudentID { get; set; }

        public Courses Course { get; set; }

        public int Courseid { get; set; }

        public Grade Grade { get; set; }

        public int Gradeid { get; set; }


    }
}
