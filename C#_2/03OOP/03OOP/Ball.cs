using System;
using System.Drawing;

namespace _03OOP
{
	public class Ball
	{
		public int Size { get; set; }
		public Color Col { get; set; }
		public int Time { get; set; }


		public Ball(int size, Color color, int time)
		{
			Size = size;
			Col = color;
			Time = time;

		}

		public void Pop()
		{
			Size = 0;
		}
		public void Throw()
		{
			if (Size> 0){
				Time += 1;
			}
			else
			{
				Console.WriteLine("The ball has been popped");
			}
		}

		public int NumberOfThrow()
		{
			return Time;
		}
    }
}

