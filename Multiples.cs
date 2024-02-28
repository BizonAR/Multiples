using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples
{
	internal class Multiples
	{
		static void Main(string[] args)
		{
			Random random = new Random();
			int startInterval = 1;
			int endInterval = 27;
			int numberN = random.Next(startInterval, endInterval + 1);

			int lowerLimit = 100;
			int upperLimit = 999;
			int count = 0;

			for (int i = 0; i < upperLimit; i += numberN)
			{
				if (i > lowerLimit)
					count++;
			}

			Console.WriteLine($"Количество трёхзначных чисел кратных {numberN}: {count}");
		}
	}
}
