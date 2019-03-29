using System;

namespace CodeKata.Con {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Hello");
			Console.WriteLine("Enter first number");
			string numberOneString = Console.ReadLine();

			Console.WriteLine("Enter second number");
			string numberTwoString = Console.ReadLine();
			if (int.TryParse(numberOneString, out int numberOne) && int.TryParse(numberTwoString, out int numberTwo)) {

				LovelyMathClass lovelyMathClass = new LovelyMathClass();
				int result = lovelyMathClass.Add(numberOne, numberTwo);
				Console.WriteLine($"Result: {result}");

			} else {
				Console.WriteLine("One of the numbers is not valid");
			}
			Console.WriteLine("Press any key to exit...");
			Console.ReadLine();

		}
	}
}
