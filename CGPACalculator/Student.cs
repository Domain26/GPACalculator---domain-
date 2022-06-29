using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGPACalculator
{
    public class Student
    {
        public List<Course> Courses = new List<Course>();
        public Double TotalCourseUnitRegistere { get; set; }
        public Double TotalCourseUnitPassed { get; set; }
        public Double TotalWeightPoint { get; set; }
        public double Gpa { get; set; }
    }
}
