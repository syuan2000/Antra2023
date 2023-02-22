using System;
using Microsoft.VisualBasic;

namespace _02UnderstandingTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            TypesPractice demo = new TypesPractice();
            demo.PrintType();
            demo.intCenturies();

            LoopPractice demo1 = new LoopPractice();
            demo1.FizzBuzz();
            demo1.RandomGuess();
            demo1.PrintPyramid();
            demo1.BirthDate();
            demo1.Greeting();
            // not sure why did the start number is 32 instead of 0 in here...
            demo1.Increment();

            ArrayPractice demo2 = new ArrayPractice();
            demo2.CopyArray();
            demo2.listElement();
            int[] prime = demo2.FindPrimesInRange(2, 10);
            Console.WriteLine(string.Join(' ', prime));

            int[] sums = demo2.SumOfRotate();
            Console.WriteLine(string.Join(' ', sums));
            int[] test = new int[] { 0, 1, 1, 5, 2, 2, 6, 3, 3, 3 };
            demo2.LongestSeq(test);
            demo2.MostFreq(test);

            StringPractice demo3 = new StringPractice();
            Console.WriteLine("Reverse string: ");
            Console.WriteLine("________________________________");
            demo3.ReverseString("sample");
            Console.WriteLine("Reverse string with Punc: ");
            Console.WriteLine("________________________________");
            demo3.ReverseWithPunc("C# is not C++, and PHP is not Delphi!");
            Console.WriteLine("Print palindrome from string: ");
            Console.WriteLine("________________________________");
            demo3.PalindromeList("Hi,exe? ABBA! Hog fully a string: ExE. Bob");
            Console.WriteLine("Parse URL: ");
            Console.WriteLine("________________________________");
            demo3.ParseURL("", "www.apple.com","");
            demo3.ParseURL("ftp", "www.apple.com", "employee");

        }
        
    }
}

