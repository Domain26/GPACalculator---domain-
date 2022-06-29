using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGPACalculator
{
    public class Course
    {
        public Course(string courseCode, int courseUnit, int score)
        {
            CourseCode = courseCode;
            CourseUnit = courseUnit;
            Score = score;
        }
        public string CourseCode { get; set; }
        public int CourseUnit { get; set; }
        public int Score { get; set; }
        public string Grade { get; set; }
        public string Remark { get; set; }
        public int GradePoint { get; set; }
        public int WeightPoint { get; set; }
    }
}
