using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    
    static class Fillter
    {
        public static bool FilterByGrade(Student student,string grade)
        {
            return student.Grade ==Convert.ToDecimal(grade);
        }
        public static bool FilterByFirstName(Student student, string firstname)
        {
            return student.FirstName == firstname;
        }
        public static bool FilterByLastName(Student student, string lastname)
        {
            return student.LastName == lastname;
        }
        public static bool FilterById(Student student, string id)
        {
            return student.Id == id;
        }
        public static bool GradeBelow50(Student student)
        {
            return Convert.ToDecimal(student.Grade) < 50;
        }
        public static bool SameFirstCharFLNames(Student student)
        {
            return student.FirstName[0] == student.LastName[0];
        }
    }
}
