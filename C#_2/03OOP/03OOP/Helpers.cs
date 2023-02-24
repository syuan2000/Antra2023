using System;
namespace _03OOP
{
	public class Helpers
	{
		public static int[] GenerateNumbers(int len)
		{
			int[] array = new int[len];
			for(int i = 0; i < len; i++)
			{
				array[i] = i+1;
			}
			return array;
		}

		public static void Reverse(int[] array) {
			int n = array.Length;
			int mid = n / 2;
			for(int i = 0; i < mid; i++)
			{
				int temp = array[i];
				int back = n - 1 - i;
				array[i] = array[back];
				array[back] = temp;
			}
		}

		public static void PrintNumbers(int[] array)
		{
            Console.WriteLine("Reverse Sequence:");
            foreach (int a in array)
			{
				
				Console.Write(a+ " ");
			}
		}

		public static int Fibonacci(int len)
		{
			if (len==1 || len== 2){
				return 1;
			}
			
			int first = 1, second = 1;
			int cur = 0;

			for(int i = 3; i <= len; i++)
			{
				cur = first + second;
				first = second;
				second = cur;
			}
			return cur;
		}
	}
}

