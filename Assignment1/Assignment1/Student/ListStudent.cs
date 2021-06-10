using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Student
{
    public class ListStudent
    {
        public List<SchoolStudent> schoolStudents = new List<SchoolStudent>()
        {
            new SchoolStudent()
            {
                Id = 1,
                FirstName = "Rutvik",
                LastName = "Rupapara",
                InterestedInMusic = true,
                InteresteInSports = false,
                Age = 15,
                RegisterationTime = DateTime.Now.Date,
                Address = "Surat",
                IsSchoolStudent = true
            },
            new SchoolStudent()
            {
                Id = 2,
                FirstName = "Akshay",
                LastName = "Khunt",
                InterestedInMusic = true,
                InteresteInSports = true,
                Age = 20,
                RegisterationTime = new DateTime(2015, 12, 31),
                Address = "Surat",
                IsSchoolStudent = true
            },
            new SchoolStudent()
            {
                Id = 3,
                FirstName = "Sameer",
                LastName = "Bhuva",
                InterestedInMusic = true,
                InteresteInSports = true,
                Age = 25,
                RegisterationTime = new DateTime(2020, 06, 24),
                Address = "Ahmedabad",
                IsSchoolStudent = true
            }
        };
    }
}
