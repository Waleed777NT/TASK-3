using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK3
{
    public class Courses
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Credits { get; set; }

        public List<Enrollment> Enrollments { get; set; }
        = new List<Enrollment>();

        public Teacher Teacher { get; set; }

        public int TeacherId { get; set; }
    }
}
