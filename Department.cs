using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK3
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Teacher> Teachers { get; set; }
    }
}
