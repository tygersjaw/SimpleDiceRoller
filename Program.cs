using System;

namespace DiceRoller
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// bool keepGoing = true;
			string dieChoice;
			int dieQuantity;
			//char calculateAverage;

			Console.WriteLine("Which die are you rolling? < d4 | d6 | d8 | d10 | d12 | d20 >\n");
			dieChoice = Console.ReadLine();
			Console.WriteLine("How many?\n");
			dieQuantity = Convert.ToInt32(Console.ReadLine());
			//Console.WriteLine("Do you want an average calculated? < Y/N >");
			//calculateAverage = Console.ReadLine();

			//if ((calculateAverage != 'y') || calculateAverage != 'n')
			//	Console.WriteLine("That's not valid input.");


			if (dieChoice == "d4")
			{
				d4(dieQuantity);
			}
			else if (dieChoice == "d6")
			{
				d6(dieQuantity);
			}
			else if (dieChoice == "d8")
			{
				d8(dieQuantity);
			}
			else if (dieChoice == "d10")
			{
				d10(dieQuantity);
			}
			else if (dieChoice == "d12")
			{
				d12(dieQuantity);
			}
			else if (dieChoice == "d20")
			{
				d20(dieQuantity);
			}
			else
				Console.WriteLine("Sorry that's not valid input.");



			Console.ReadKey();
			

		}

		public static void d4(int dieQuantity)
		{
			int attempt = 0;
			int total = 0;
			int average = 0;
			Random rnd = new Random();

			while (attempt != dieQuantity)
			{
				int dieValue = rnd.Next(1, 5);
				Console.WriteLine(dieValue);
				total = total + dieValue;
				attempt++;

				if (attempt == dieQuantity)
				{
					average = total / dieQuantity;
					Console.WriteLine("Your average is " + average);
				}
			}

		}

		public static void d6(int dieQuantity)
		{

			int attempt = 0;
			int total = 0;
			int average = 0;
			Random rnd = new Random();

			while (attempt != dieQuantity)
			{
				int dieValue = rnd.Next(1, 7);
				Console.WriteLine(dieValue);
				total = total + dieValue;
				attempt++;

				if (attempt == dieQuantity)
				{
					average = total / dieQuantity;
					Console.WriteLine("Your average is " + average);
				}
			}
		}

		public static void d8(int dieQuantity)
		{

			int attempt = 0;
			int total = 0;
			int average = 0;
			Random rnd = new Random();

			while (attempt != dieQuantity)
			{
				int dieValue = rnd.Next(1, 9);
			Console.WriteLine(dieValue);
				total = total + dieValue;
				attempt++;

				if (attempt == dieQuantity)
				{
					average = total / dieQuantity;
					Console.WriteLine("Your average is " + average);
				}
			}
		}

		public static void d10(int dieQuantity)
		{
			int attempt = 0;
			int total = 0;
			int average = 0;
			Random rnd = new Random();

			while (attempt != dieQuantity)
			{
				int dieValue = rnd.Next(1, 11);
				Console.WriteLine(dieValue);
				total = total + dieValue;
				attempt++;

				if (attempt == dieQuantity)
				{
					average = total / dieQuantity;
					Console.WriteLine("Your average is " + average);
				}
			}
		}

		public static void d12(int dieQuantity)
		{
			int attempt = 0;
			int total = 0;
			int average = 0;
			Random rnd = new Random();

			while (attempt != dieQuantity)
			{
				int dieValue = rnd.Next(1, 13);
				Console.WriteLine(dieValue);
				total = total + dieValue;
				attempt++;

				if (attempt == dieQuantity)
				{
					average = total / dieQuantity;
					Console.WriteLine("Your average is " + average);
				}
			}

		}

		public static void d20(int dieQuantity)
		{
			int attempt = 0;
			int total = 0;
			int average = 0;
			Random rnd = new Random();

			while (attempt != dieQuantity)
			{
				int dieValue = rnd.Next(1, 21);
				Console.WriteLine(dieValue);
				total = total + dieValue;
				attempt++;

				if (attempt == dieQuantity)
				{
					average = total / dieQuantity;
					Console.WriteLine("Your average is " + average);
				}
			}
		}
	}
}
