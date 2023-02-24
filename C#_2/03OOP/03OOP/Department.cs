using System;
namespace _03OOP
{
    public class Department : IDepartmentService
    {
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Course> Courses { get; set; }

        public Department(string name, DateTime startDate, DateTime endDate)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            Courses = new List<Course> { };
        }

        public decimal GetBudget()
        {
            Budget = (StartDate.Year - EndDate.Year) * 1000;
            return Budget;
        }

        public List<Course> GetCourses()
        {
            return Courses;
        }

    }


}

