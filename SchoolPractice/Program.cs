using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            var Student = new Student();
            Student.NameGetter = "Chance";
            Student.StudentName();
            Student.Credits = 1;
            Student.TotalCredits();
            Student.GpaGetter = 4.0;
            Student.CumulativeGpa();

            Student Student2 = new Student("Roger", 123, 1);
            Student2.NameGetter = "Chauncey";
            
            Student2.StudentName();
            Console.WriteLine(Student2.StudentId);
            Student2.TotalCredits();
            Student.CumulativeGpa();

            List<string> studentNameList = new List<string>()
            {
                "Mary",
                "Kate",
                "Ashley"
            };

            Course courseMath = new Course("Math", "Algebra", "Professor Hussein", studentNameList);
            courseMath.CourseName();

            Course courseEnglish = new Course("English", "Vocab", "Professor Blake", studentNameList);
            courseEnglish.StudentRoster();


            Teacher Roger = new Teacher("Roger","Campbell", "CSharp", 20);
            Roger.TeachingExp();
            Roger.AllMethods();
            
            
            
            
            
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
        }
    }
}
