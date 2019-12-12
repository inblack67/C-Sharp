using System;

namespace ParamsAndRef
{
	class Program
	{
		public static void Main(string[] args)
		{
			int a = 17;

			Console.WriteLine("Params");

			var calc = new Calculator();
			Console.WriteLine("Calculator.add() -> " + calc.add(1, 2, 3, 4, 5));
			// numbers can be added without overloading specific number of arguments each time
			Console.WriteLine();

			Console.WriteLine("Ref");

			Console.WriteLine("Main().a -> " + a);
			Console.WriteLine("Calculator.increment() -> " + calc.increment(ref a));
			Console.WriteLine("Changed Main().a -> " + a);
			Console.WriteLine();
		}

	}

	public class Calculator
	{
		public int add(params int[] numbers)      // params modifier has to be 1D array
		{
			int sum = 0;
			foreach (var x in numbers)
				sum += x;
			return sum;
		}

		public int increment(ref int a)
		{
			return ++a;
		}
	}
}
