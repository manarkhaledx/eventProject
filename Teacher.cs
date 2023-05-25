using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Teacher
    {
        // Properties
        public int TeacherID { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public List<string> CoursesTaught { get; }

        // Constructor
        public Teacher(int teacherId, string name, string specialization)
        {
            TeacherID = teacherId;
            Name = name;
            Specialization = specialization;
            CoursesTaught = new List<string>();
        }

        // Method to add a course taught by the teacher
        public void AddCourse(string courseName)
        {
            CoursesTaught.Add(courseName);
        }

        // Method to remove a course taught by the teacher
        public void RemoveCourse(string courseName)
        {
            CoursesTaught.Remove(courseName);
        }
    }
}
