using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f
{
	class Program
	{
		static void Main(string[] args)
		{
			HelloWorld();
			int result = Mul5by5();
		}

		private static int Mul5by5()
		{
			int a = 5;
			int b = a * 5;
			return b;
		}

		private static void HelloWorld()
		{
			Console.WriteLine("Hello");
			Console.WriteLine("World!");
		}
	}
}
