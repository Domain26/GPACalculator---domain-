using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGPACalculator
{
    class DataPopulation
    {
      
        public static Course PopulateCourse(Course course)
        {
            if(course.Score > 70)
            {
                course.Grade = Convert.ToString(Grade.A);
                course.GradePoint = (int) Grade.A;
                course.Remark = "Excellent";
                course.WeightPoint = course.CourseUnit * course.GradePoint;
            }
            else if (course.Score < 70 && course.Score >= 60)
            {
                course.Grade = Convert.ToString(Grade.B);
                course.GradePoint = (int)Grade.B;
                course.Remark = "Very Good";
                course.WeightPoint = course.CourseUnit * course.GradePoint;
            }
            else if (course.Score < 60 && course.Score >= 50)
            {
                course.Grade = Convert.ToString(Grade.C);
                course.GradePoint = (int)Grade.C;
                course.Remark = "Good";
                course.WeightPoint = course.CourseUnit * course.GradePoint;
            }
            else if (course.Score < 50 && course.Score >= 45)
            {
                course.Grade = Convert.ToString(Grade.D);
                course.GradePoint = (int)Grade.D;
                course.Remark = "Pass";
                course.WeightPoint = course.CourseUnit * course.GradePoint;
            }
            else if (course.Score < 45 && course.Score >= 40)
            {
                course.Grade = Convert.ToString(Grade.E);
                course.GradePoint = (int)Grade.E;
                course.Remark = "Fair";
                course.WeightPoint = course.CourseUnit * course.GradePoint;
            }
            else if (course.Score < 40 && course.Score >= 0)
            {
                course.Grade = Convert.ToString(Grade.F);
                course.GradePoint = (int)Grade.F;
                course.Remark = "Fail";
                course.WeightPoint = course.CourseUnit * course.GradePoint;
            }
            return course;
        }

        public static void GpaCalculation(Student student)
        {
            foreach (Course course in student.Courses)
            {
                student.TotalCourseUnitRegistere += course.CourseUnit;
                student.TotalWeightPoint += course.WeightPoint;
                if(Convert.ToInt32(course.Score) > 39)
                {
                    student.TotalCourseUnitPassed += course.CourseUnit;
                }

                student.Gpa = student.TotalWeightPoint / student.TotalCourseUnitPassed;
            }
        }
    }
}
