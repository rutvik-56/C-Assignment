using Assignment1.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Delegate
{
    public class DelegatesExample
    {
        public void IsEligible(List<SchoolStudent> schoolStudent, Predicate<SchoolStudent> isAgeValid, Func<SchoolStudent, bool> isDateValid)
        {
            foreach(SchoolStudent student in schoolStudent)
            {
                if (isAgeValid(student) && isDateValid(student))
                {
                    Console.WriteLine(student.FirstName);
                }
            }
        }
    }
}
