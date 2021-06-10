using Assignment1.Country;
using Assignment1.Delegate;
using Assignment1.Student;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            CountryList countryList = new CountryList();
            Console.WriteLine($"Count of countries which starts with I : {countryList.GetCountOfIPrefixCountry()}\n\n");
            Console.WriteLine("CountryNames in group of their countryName:\n\n");
            var result = new SortedDictionary<int, List<string>>(countryList.GetGroupByCountryByLength());
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} : {String.Join(", ", item.Value)}");
            }
            Console.WriteLine("\n\n\n");


            // 2 
            SchoolStudent schoolStudent = new SchoolStudent()
            {
                Id = 1,
                FirstName = "Rutvik",
                LastName = "Rupapara",
                InterestedInMusic = true,
                InteresteInSports = false,
                Age = 21,
                RegisterationTime = DateTime.Now,
                Address = "Surat",
                IsSchoolStudent = true
            };

            CollegeStudent collegeStudent = new CollegeStudent();

            collegeStudent =  CopyProperty.Copy(schoolStudent, collegeStudent);


            Console.WriteLine("School Student Object\n\n");

            foreach(var item in schoolStudent.GetType().GetProperties())
            {
                Console.WriteLine($"{ item.Name} : {item.GetValue(schoolStudent)}");
            }

            Console.WriteLine("\n\nCollege Student Object\n\n");

            foreach (var item in collegeStudent.GetType().GetProperties())
            {
                Console.WriteLine($"{ item.Name} : {item.GetValue(collegeStudent)}");
            }

            // 3
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("Students name which have age grater than 18 and registeration year grater than 2018:\n\n");
            ListStudent listStudent = new ListStudent();
            var list = listStudent.schoolStudents;

            DelegatesExample delegatesExample = new DelegatesExample();
            delegatesExample.IsEligible(list, x => x.Age > 18, x => x.RegisterationTime.Year > 2018);

        }
    }
}
