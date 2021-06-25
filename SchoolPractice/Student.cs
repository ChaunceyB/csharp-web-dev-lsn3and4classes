using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private string Name; 
        public int StudentId;
        private int NumberOfCredits = 0;
        private double Gpa = 0.0;


        public Student()
        {
            
        }

        public Student(string providedName)
        {
            this.Name = providedName;
        }

        public Student(string providedName, int providedStudentId, int credits)
        {
            this.Name = providedName;
            this.StudentId = providedStudentId;
            this.NumberOfCredits = credits;
        }

        public string NameGetter
        {
            get { return Name; }
            set { Name = value; }
        }
        public int Credits
        {
            get { return NumberOfCredits; }
            set { NumberOfCredits = value; }
        }
        public double GpaGetter
        {
            get { return Gpa; }
            set { Gpa = value; }
        }
        public void StudentName()
        {
            Console.WriteLine(this.Name);
        }
        public void TotalCredits()
        {
            Console.WriteLine(this.NumberOfCredits);
        }
        public void CumulativeGpa()
        {
            Console.WriteLine(this.Gpa);
        }


    }
}
