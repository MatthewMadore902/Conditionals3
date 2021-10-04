using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals3
{
	class Program
	{
		static bool isAlive = true;



		static void Main(string[] args)
		{
			Console.WriteLine("Conditionals3");

			isAlive = false;
			//if (Alive == true)
			if (isAlive)
			{
				Console.WriteLine("Your are alive");
			}
			else
			{
				Console.WriteLine("You are dead");
			}

			Console.ReadKey(true);
		}
	}
}
