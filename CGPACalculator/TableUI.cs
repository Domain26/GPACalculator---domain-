using CGPACalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TableUI
{

    public static void Table(Student student)
    {
        Console.Clear();
        Console.WriteLine("\t\t|---------------|---------------|-------------|--------------|---------------|--------------|-------------|");
        Console.WriteLine("\t\t|               |               |             |              |               |              |             |");
        Console.WriteLine("\t\t|  COURSE CODE  |  COURSE UNIT  | COURSE SCORE|  GRADE POINT |  GRADE        |  WEIGHTPOINT |    REMARK   |");
        Console.WriteLine("\t\t|               |               |             |              |               |              |             |");
        Console.WriteLine("\t\t|---------------|---------------|-------------|--------------|---------------|--------------|--------------");
        foreach (Course course in student.Courses)
        {
            Console.WriteLine("\t\t|               |               |             |              |               |              " +
                   "|             |");
                Console.WriteLine("\t\t|  " + course.CourseCode + "       |       " + course.CourseUnit + "       |     " +    
                      + course.Score + "      |       "               + course.Grade + "   " +
                    "   |     " + course.CourseUnit + "         |    " + course.WeightPoint + "        |  " + course.Remark +
                    "   |");
                Console.WriteLine("\t\t|               |               |             |              |               |              |             |");
                Console.WriteLine("\t\t|---------------|---------------|-------------|--------------|---------------|--------------|-------------|");
            }
        }

    }

