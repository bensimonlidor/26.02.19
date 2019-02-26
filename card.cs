using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardsgame.cs
{
	class Program
	{
		static void Main(string[] args)
		{
			Random engine = new Random();

			// get new card
			int mycard = engine.Next(2, 15);
			switch (mycard)
			{
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
					Console.WriteLine(mycard);
					break;
				case 11:
					Console.WriteLine("J");
					break;
				case 12:
					Console.WriteLine("Q");
					break;
				case 13:
					Console.WriteLine("K");
					break;
				case 14:
					Console.WriteLine("A");
					break;
				default:
					Console.WriteLine("Bad card!!!!!!!!!!!");
					break;
			}

			Thread.Sleep(3000);

			// get new card
			int computercard = engine.Next(2, 15);
			// print card
			switch (computercard)
			{
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
					Console.WriteLine(computercard);
					break;
				case 11:
					Console.WriteLine("J");
					break;
				case 12:
					Console.WriteLine("Q");
					break;
				case 13:
					Console.WriteLine("K");
					break;
				case 14:
					Console.WriteLine("A");
					break;
				default:
					Console.WriteLine("Bad card!!!!!!!!!!!");
					break;
			}

			Thread.Sleep(500);

			if (mycard > computercard)
			{
				Console.WriteLine("I won this round!!!!");
			}
			else if (computercard > mycard)
			{
				Console.WriteLine("Computer won ... booooo");
			}
			else
			{
				Console.WriteLine("Tie!");
			}
      
      // how get to 5 win???
		
		}
	}
}
		
