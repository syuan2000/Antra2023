using System;
namespace _02UnderstandingTypes
{
	public class TypesPractice
	{
        public void PrintType()
        {
            Console.WriteLine("sbyte\nSize: 1 byte\nMin/Max: -128, 127\n");
            Console.WriteLine("byte\nSize: 1 byte\nMin/Max: 0, 255\n");
            Console.WriteLine("short\nSize: 2 bytes\nMin/Max: -32,768, 32,767\n");
            Console.WriteLine("ushort\nSize: 2 bytes\nMin/Max: 0, 65,535\n");
            Console.WriteLine("int\nSize: 4 bytes\nMin/Max: -2,147,483,648, 2,147,483,647\n");
            Console.WriteLine("uint\nSize: 4 bytes\nMin/Max: 0, 4,294,967,295\n");
            Console.WriteLine("long\nSize: 8 bytes\nMin/Max: -9,223,372,036,854,775,808, 9,223,372,036,854,775,807\n");
            Console.WriteLine("ulong\nSize: 8 bytes\nMin/Max: 0, 18,446,744,073,709,551,615\n");
            Console.WriteLine("float\nSize: 4 bytes\nMin/Max: -1.0e-45, 3.4e38\n");
            Console.WriteLine("doubl\nSize: 8 bytes\nMin/Max: -5.0 × 10^-324, 1.7 × 10^308\n");
            Console.WriteLine("decimal\nSize: 16 bytes\nMin/Max: -1.0 × 10^-28, 7.9 × 10^28\n");
        }
        public void intCenturies()
		{
			Console.WriteLine("Enter number of Centuries: ");
			int centuries = int.Parse(Console.ReadLine());

            ulong years = (ulong)(centuries * 100);
            ulong days = years * 365 + years / 4 - years / 100 + years / 400;
            ulong hours = days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            ulong milliseconds = seconds * 1000;
            ulong microseconds = milliseconds * 1000;
            ulong nanoseconds = microseconds * 1000;

            // Display the results
            Console.WriteLine($"{centuries} centuries = ");
            Console.WriteLine($"{years} years = ");
            Console.WriteLine($"{days} days = ");
            Console.WriteLine($"{hours} hours = ");
            Console.WriteLine($"{minutes} minutes = ");
            Console.WriteLine($"{seconds} seconds = ");
            Console.WriteLine($"{milliseconds} milliseconds = ");
            Console.WriteLine($"{microseconds} microseconds = ");
            Console.WriteLine($"{nanoseconds} nanoseconds");

        }

	}
}

