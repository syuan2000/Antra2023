using System;
namespace _03OOP
{
	public interface IPersonService
	{
        int CalculateAge();
        decimal CalculateSalary(decimal baseSalary);
    }
    public interface IStudentService : IPersonService
    {

        decimal CalculateGPA();
    }

    public interface IInstructorService : IPersonService
    {
        bool IsDepartmentHead();
        decimal CalculateBonusSalary(decimal salary, DateTime joinDate);
    }

    public interface IDepartmentService
    {
        decimal GetBudget();
        List<Course> GetCourses();
    }
    public interface ICourseService
    {
        List<Student> GetEnrolledStudents();
    }
}

