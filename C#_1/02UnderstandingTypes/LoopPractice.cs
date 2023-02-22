using System;
namespace _02UnderstandingTypes
{
	public class LoopPractice
	{
		public void FizzBuzz()
		{
			for (byte i =1; i<=100; i++)
			{
				if (i%3==0 && i % 5==0)
				{
					Console.WriteLine("Fizzbuzz");
				}
				else if (i % 3 == 0)
				{
                    Console.WriteLine("Fizz");
                }
				else if (i % 5 == 0)
				{
                    Console.WriteLine("Buzz");
                }
				else
				{
                    Console.WriteLine(i);
                }

			}
		}

		public void RandomGuess()
		{
            Console.WriteLine("\nI'm thinking of a number between 1 and 3. Can you guess what it is?");
            int guessedNumber = int.Parse(Console.ReadLine());
			int correctNumber = new Random().Next(3) + 1;
      

			if (guessedNumber > correctNumber) {
                Console.WriteLine("the guess is too high\n");
            }
            else if (guessedNumber < correctNumber)
            {
                Console.WriteLine("the guess is too high\n");
            }
            else if (guessedNumber>3 || guessedNumber<1)
            {
                Console.WriteLine("the guess is out of range\n");
            }
            else
            {
                Console.WriteLine("the guess is correct!\n");
            }


        }

		public void PrintPyramid()
		{
			for (int i = 1; i < 6; i++)
			{
                Console.Write(new string(' ', 5-i));
                Console.Write(new string('*', 2*i-1));
                Console.Write(new string(' ', 5 - i));
				Console.WriteLine();
            }
		}
		public void BirthDate()
		{
            DateTime birthDate = new DateTime(2000, 9, 1);
            DateTime currentDate = DateTime.Today;
            TimeSpan age = currentDate - birthDate;
            Console.WriteLine("You are currently " + age.TotalDays + " days old.");
            int daysToNextAnniversary = 10000 - ((int)age.TotalDays % 10000);
            Console.WriteLine("You are currently " + daysToNextAnniversary + " till 10000 days old\n");
        }

		public void Greeting()
		{
            DateTime currentTime = DateTime.Now;
            int hour = currentTime.Hour;
            if (hour<12 && hour > 6)
            {
                Console.WriteLine("Good morning!\n");
            }
            if (hour > 12 && hour < 17)
            {
                Console.WriteLine("Good afternoon!\n");
            }
            if (hour > 17 && hour < 20)
            {
                Console.WriteLine("Good evening!\n");
            }
            if (hour < 6 && hour > 20)
            {
                Console.WriteLine("Good night!\n");
            }

        }
        public void Increment()
        {
            for (int i = 1; i <=4; i++)
            {
                Console.WriteLine($"Counting by {i}s:");
                for (int j = 0; j <= 24; j+=i)
                {
                    Console.Write(j+ ' ');
                }
                Console.WriteLine();
            }
        }

	}
}

