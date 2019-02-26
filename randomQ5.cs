using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomQ5.CS
{
	class Program
	{
		static void Main(string[] args)
		{
			int guess;
			Random engine = new Random();
			int secert = engine.Next(100) + 1;
			int counter = 1;
			guess = Convert.ToInt32(Console.ReadLine());
			while (secert != guess)
			{
				counter++;
				if (guess < secert)
				{
					Console.WriteLine("too small");
				}
				else
				{
					Console.WriteLine("too big");
				}
				guess = Convert.ToInt32(Console.ReadLine());
			}

			Console.WriteLine("bingo");

		}
	}
}
		
