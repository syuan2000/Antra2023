using System;
namespace _03OOP
{
	public class Course: ICourseService
	{
        public string Name { get; set; }
        public List<Student> EnrolledStudents { get; set; }

        public Course (string name, List<Student> enrolledStudents)
        {
            Name = name;
            EnrolledStudents = enrolledStudents;
        }

        public List<Student> GetEnrolledStudents()
        {
            return EnrolledStudents;
        }

    }
}

