using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Averages
    {
        public static decimal AverageAge(Student student)
        {
            return Convert.ToDecimal(student.Age);
        }
        public static decimal AverageGrade(Student student)
        {
            return Convert.ToDecimal(student.Grade);
        }
    }
}
