using System;
using System.Runtime.InteropServices;

namespace _03OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Working with methods
            // 1.
            int[] numbers = Helpers.GenerateNumbers(10);
            Helpers.Reverse(numbers);
            Helpers.PrintNumbers(numbers);

            Console.WriteLine();
            //2.Fibonacci
            Console.WriteLine();
            Console.WriteLine("Fibonacci");
            Console.WriteLine("-----------------");
            for (int i = 1; i <= 10; i++)
            {
                int seq = Helpers.Fibonacci(i);
                Console.WriteLine(seq);
            }

            // Building Classes
            // School  OOP structures
            Console.WriteLine();
            Console.WriteLine("School OOP Structure");
            Console.WriteLine("-----------------");
            Student student1 = new Student("Eva", new DateTime(2000, 3, 1));
            Student student2 = new Student("Joy", new DateTime(1999, 10, 12));
            Student student3 = new Student("Jenny", new DateTime(1998, 1, 28));
            Student student4 = new Student("Pat", new DateTime(1993, 2, 9));

            Course course1 = new Course("Intro to IT", new List<Student>{ student1, student2 });
            Course course2 = new Course("Bio is life", new List<Student> { student3, student2 });
            Course course3 = new Course("Gen-eds", new List<Student> { student1, student2, student3, student4 });


            student1.AddCourse("Intro to IT", "A");
            student1.AddCourse("Gen-eds", "B");

            List<Student> required = course3.GetEnrolledStudents();
            Console.WriteLine("Student(s) that is enrolled in Gen-eds");
            foreach (var s in required) {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();

            Department iT = new Department("IT", new DateTime(1990, 1, 1), DateTime.Now);

            Instructor instructor1 = new Instructor("Brian", new DateTime(1969, 11, 15), new DateTime(2010, 8,20), iT, true);
            Instructor instructor2 = new Instructor("David", new DateTime(1980, 3, 8), new DateTime(2016, 8, 22), iT, false);
            Instructor instructor3 = new Instructor("Kris", new DateTime(1982, 4, 27), new DateTime(2018, 8, 19), iT, false);

            






            // Color & Balls
            Console.WriteLine();
            Console.WriteLine("Color & Ball");
            Console.WriteLine("-----------------");
            Ball ball1 = new Ball(3, new Color(5, 100, 25), 0);
            Ball ball2 = new Ball(1, new Color(125, 255, 0,150), 0);
            Ball ball3 = new Ball(5, new Color(0, 125, 255), 2);

            ball1.Throw();
            ball1.Throw();
            Console.WriteLine("Number of time being thrown: " + ball1.NumberOfThrow());

            ball1.Pop();
            ball1.Throw();
            // should be 2 cuz the popped balls can't be changed
            Console.WriteLine("Number of time being thrown: " + ball1.NumberOfThrow());


            Console.WriteLine("The Gray scale of this ball is : " + ball1.Col.GrayScale());

            ball3.Throw();
            Console.WriteLine("Number of time being thrown: " + ball3.NumberOfThrow());


        }

    }

}