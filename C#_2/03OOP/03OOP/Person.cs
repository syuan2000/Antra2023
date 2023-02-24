using System;
namespace _03OOP
{
    public abstract class Person : IPersonService
    {
        // ENCAPSULATION
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public List<string> Addresses { get; set; }

        //constructor
        public Person(string name,  DateTime birthdate)
        {
            Name = name;
            Birthdate = birthdate;
            Addresses = new List<string>();
        }

        public virtual int CalculateAge()
        {
            return DateTime.Now.Year - Birthdate.Year;
        }
        public virtual decimal CalculateSalary(decimal salary)
        {
            if (salary < 0)
            {
                throw new ArgumentException("Salary can't be negative number!");
            }
            return salary;
        }


    }

    public class Student : Person, IStudentService
    {

        public List<string> Courses { get; set; }
        public List<string> Grades { get; set; }

        //constructor
        public Student(string name, DateTime birthdate) : base(name, birthdate)
        {
            Courses = new List<string>();
            Grades = new List<string>();
        }


        public void AddCourse(string course, string grade)
        {
            Courses.Add(course);
            Grades.Add(grade);
        }

        public decimal CalculateGPA()
        {
            if (Courses.Count == 0)
            {
                return 0;
            }
            decimal totalPoints = 0;
            foreach (string grade in Grades)
            {
                switch (grade)
                {
                    case "A":
                        totalPoints += 4;
                        break;
                    case "B":
                        totalPoints += 3;
                        break;
                    case "C":
                        totalPoints += 2;
                        break;
                    case "D":
                        totalPoints += 1;
                        break;
                    case "F":
                        totalPoints += 0;
                        break;
                    default:
                        throw new ArgumentException("Invalid grade.");
                }
            }
            return totalPoints / Courses.Count;
        }
    }

    public class Instructor : Person, IInstructorService
    {
        public DateTime JoinDate { get; set; }
        public Department Department { get; set; }
        public bool IsHeadInstructor { get; set; }
        public List<Instructor> Instructors;

        public Instructor(string name, DateTime birthdate, DateTime joinDate, Department department, bool isHeadInstructor) : base(name, birthdate)
        {
            JoinDate = joinDate;
            Department = department;
            IsHeadInstructor = isHeadInstructor;
            Instructors.Add(new Instructor(name, birthdate, joinDate, department, isHeadInstructor));
        }


        public bool IsDepartmentHead()
        {
            return IsHeadInstructor;
        }
        public decimal CalculateBonusSalary(decimal salary, DateTime joinDate)
        {
            decimal bonus = (joinDate.Year - DateTime.Now.Year) * 1000;
            return salary + bonus;

        }

    }
}


