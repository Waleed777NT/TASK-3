﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK3
{
    public class Teacher
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Department Department { get; set; }

        public int DepartmentId { get; set; }

       public List<Courses> Courses { get; set; }


    }
}
