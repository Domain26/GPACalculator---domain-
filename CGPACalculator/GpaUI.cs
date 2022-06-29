using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGPACalculator
{
    class GpaUI
    {
        public static void Start()
        {
            Student student = new Student();
            while (true)
            {

                Console.Write("Enter Course code: ");
                string courseCode = Console.ReadLine();

                Console.Write("Enter Score: ");
                int score = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Course unit: ");
                int courseUnit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Press 2 to input another course or 1 to print result");

                int options = Convert.ToInt32(Console.ReadLine());
                Course course = new Course(courseCode, courseUnit, score);
                DataPopulation.PopulateCourse(course);
                student.Courses.Add(course);
                while (options != 1 && options != 2)
                {
                    Console.WriteLine("Invalid input, Enter a valid command");
                    options = Convert.ToInt32(Console.ReadLine());
                }
                if (options == 1)
                {
                    break;
                }

                Console.Clear();
            }

            DataPopulation.GpaCalculation(student);
            TableUI.Table(student);

            /*foreach (Course course in student.Courses)
            {
                Console.WriteLine($"CourseCode: {course.CourseCode}, CourseUnit: {course.CourseUnit}, CourseScore: {course.Score}, CourseGradePoint {course.GradePoint}, "
                     + $"CourseGrade: {course.Grade}, CourseWeightPoint {course.WeightPoint}, CourseRemark {course.Remark}");
            }
            Console.WriteLine("Total Course Unit Registered is: {0}", student.TotalCourseUnitRegistere);
            Console.WriteLine("Total Course Unit Passed is: {0}", student.TotalCourseUnitPassed);
            Console.WriteLine("Total Weight Point is: {0}", student.TotalWeightPoint);
            Console.WriteLine("Your GPA is = {0}", Math.Round(student.Gpa, 2));
        }*/
        }
    }
}
