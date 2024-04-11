// See https://aka.ms/new-console-template for more information

using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Xml.XPath;

Console.WriteLine("Hello, welcome to the calculator program");

while (true)
{
	int num1, num2, result;
	string? answer;


	Console.WriteLine("Please, enter you first number");
	while (!int.TryParse(Console.ReadLine(), out num1))
		Console.WriteLine("Invalid input! Please enter a valid number:");

	Console.WriteLine("Please, enter a second number");
	while (!int.TryParse(Console.ReadLine(), out num2))
		Console.WriteLine("Invalid input! Please enter a valid number:");

	System.Console.WriteLine("What type of operation would you like to do ?");

	while (true)
	{
		System.Console.WriteLine("Please type a for addition, s for substraction, d for division or m for multiplication");
		answer = Console.ReadLine();
		if (answer == "a")
		{
			result = num1 + num2;
			break;
		}
		else if (answer == "s")
		{
			result = num1 - num2;
			break;
		}
		else if (answer == "d")
		{
			if (num2 == 0)
			{
				Console.WriteLine("Error: Division by zero!");
				continue;
			}
			result = num1 / num2;
			break;
		}
		else if (answer == "m")
		{
			result = num1 * num2;
			break;
		}
		else
		{
			Console.WriteLine("Invalid operation type");
			continue;
		}
	}
	System.Console.WriteLine("The result is: " + result);
	System.Console.WriteLine("\n----------LETS DO IT AGAIN--------\n");
}

