using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public List<string> RegisteredCourses { get; }
        public string Password { get; set; }
        public string Email { get; set; }

        // Constructor
        public Student(int StudentId, string name, int age, string gender, string password, string email)
        {
            StudentID = StudentId;
            Name = name;
            Age = age;
            Gender = gender;
            RegisteredCourses = new List<string>();
            Password = password;
            Email = email;
        }

        // Method to register for a course
        public void RegisterCourse(string courseName)
        {
            RegisteredCourses.Add(courseName);
        }

        // Method to unregister from a course
        public void UnregisterCourse(string courseName)
        {
            RegisteredCourses.Remove(courseName);
        }
    }
}
