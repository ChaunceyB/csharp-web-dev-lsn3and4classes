using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Course
    {
        private string courseName;
        private string topic;        
        private string instructorName;
        private List<string> studentRoster = new List<string> { };


        public Course(string providedCourse, string providedTopic, string providedInstructorName, List<string> providedStudentRoster)
        {
            this.courseName = providedCourse;
            this.topic = providedTopic;
            this.instructorName = providedInstructorName;
            this.studentRoster = providedStudentRoster;
        }

        public void CourseName()
        {
            Console.WriteLine(this.courseName);
        }
        public void CourseTopic()
        {
            Console.WriteLine(this.topic);
        }
        public void InstructorName()
        {
            Console.WriteLine(this.instructorName);
        }
        public void StudentRoster()
        {
            foreach (var student in studentRoster)
            {
                Console.WriteLine(student);
            }            
        }
    }
}
