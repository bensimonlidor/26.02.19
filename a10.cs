using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method1.cs
{
	class Program
	{
		static void Main(string[] args)
		{
			times3();
			times3();
			times3();
		}

		private static void times3()
		{
			int a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(a * 10);
		}
	}

}

