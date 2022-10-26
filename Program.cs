using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximizingXor
{
	class Program
	{
		public static int maximizingXor(int l, int r)
		{
			var res = new List<int>();

			for (int i = l; i <= r; i++)
			{
				for (int j = i; j <= r; j++)
				{
					res.Add(i ^ j);
				}
			}

			return res.Max();
		}

		static void Main(string[] args)
		{

			int l = Convert.ToInt32(Console.ReadLine().Trim());
			int r = Convert.ToInt32(Console.ReadLine().Trim());

			int result = maximizingXor(l, r);

			Console.WriteLine(result);

			Console.ReadKey();
		}
	}
}
