using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Teacher
    {
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string subject { get; set; }
        private int yearsTeaching { get; set; }

        public Teacher(string providedFirstName, string providedLastName, string providedSubject, int providedYearsExp)
        {
            this.firstName = providedFirstName;
            this.lastName = providedLastName;
            this.subject = providedSubject;
            this.yearsTeaching = providedYearsExp;
        }


        public void Name()
        {
            Console.WriteLine(this.firstName + this.lastName);
        }
        public void Subject()
        {
            Console.WriteLine(this.subject);
        }
        public void TeachingExp()
        {
            Console.WriteLine(this.yearsTeaching);
        }


        public void AllMethods()
        {
            Name();
            Subject();
            TeachingExp();
        }

       

    }
}
