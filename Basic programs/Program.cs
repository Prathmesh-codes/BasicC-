using System;

namespace Expt1
{

	class Experiment
	{
		static void Main(string[] args)

		{
			int option;
			Console.WriteLine("\n1]Addition Program\n2]Pattern program\n3]Factorial Program\n4]Prime No Program\n5]Matrix Program");
			Console.WriteLine("\nSelect option-");
			option = int.Parse(Console.ReadLine());

			switch (option)
			{

				case 1:

					{
						addition();
						break;
					}

				case 2:

					{
						star2();
						break;
					}


				case 3:

					{
						fact();
						break;
					}

				case 4:

					{
						prime();
						break;
					}

				case 5:

					{
						matrix();
						break;
					}

				default:
					{
						Console.WriteLine("Invalid option");
						break;
					}
			}
		}

		static void addition()
		{


			Console.WriteLine("Program for addition of numbers");

			int a, b, sum;

			Console.WriteLine("Enter first number-");
			a = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter Second number-");
			b = int.Parse(Console.ReadLine());

			sum = a + b;
			Console.WriteLine("Sum=" + sum);
		}


		static void fact()
		{

			Console.WriteLine("Program for calculating factorial of a number");

			int a, f = 1, i;

			Console.WriteLine("Enter a number-");
			a = int.Parse(Console.ReadLine());

			for (i = a; i > 0; i--)
			{

				f = f * i;

			}

			Console.WriteLine("Factorial is =" + f);
		}


		static void star1()
		{

			int i, j;

			for (i = 1; i <= 6; i++)
			{
				for (j = i; j >= i; j++)
				{

					Console.Write("\t*");
				}

				Console.Write("\n");

			}
		}

		static void star2()
		{

			int i, j, rows, k = 0;
			Console.Write("\n\n\t\t Enter no of rows-");
			rows = int.Parse(Console.ReadLine());

			for (i = 1; i <= rows; ++i, k = 0)
			{
				for (j = 1; j <= rows - i; ++j)
					k = 0;
				{

					Console.Write("");
				}

				while (k != 2 * i - 1)
				{

					Console.Write("*");
					++k;

				}

				Console.Write("\n");
			}

		}

		static void prime()
		{
			Console.WriteLine("Program for finding whether the number is prime or not of");

			int a, i, temp = 0;

			Console.WriteLine("Enter a number-");
			a = int.Parse(Console.ReadLine());

			for (i = 2; i <= a / 2; i++)

			{

				if (a % i == 0)

				{
					temp = 1;
				}
			}

			if (temp == 1)
			{

				Console.WriteLine("Given number is a not a prime number");

			}
			else if (a == 2)

			{
				Console.WriteLine("Given no is a prime number");
			}

			else
			{
				Console.WriteLine("Given no is a prime number");
			}

		}

		static void matrix()
		{

			int i, j, n;
			int[,] arr1 = new int[20, 20];
			int[,] arr2 = new int[20, 20];
			int[,] arr3 = new int[20, 20];

			Console.WriteLine("Enter Row & Column size of the matrix-");

			n = int.Parse(Console.ReadLine());


			Console.Write("Enter elements in the first matrix:\n");

			for (i = 0; i < n; i++)
			{
				for (j = 0; j < n; j++)
				{
					arr1[i, j] = Convert.ToInt32(Console.ReadLine());
				}
			}

			Console.Write("Enter elements in the second matrix:\n");

			for (i = 0; i < n; i++)
			{
				for (j = 0; j < n; j++)
				{
					arr2[i, j] = Convert.ToInt32(Console.ReadLine());
				}
			}

			Console.Write("\nFirst matrix is:\n");
			for (i = 0; i < n; i++)
			{
				Console.Write("\n");
				for (j = 0; j < n; j++)
					Console.Write("{0}\t", arr1[i, j]);
			}

			Console.Write("\nSecond matrix is:\n");
			for (i = 0; i < n; i++)
			{
				Console.Write("\n");
				for (j = 0; j < n; j++)
				{
					Console.Write("{0}\t", arr2[i, j]);
				}
			}

			for (i = 0; i < n; i++)
			{
				for (j = 0; j < n; j++)
				{
					arr3[i, j] = arr1[i, j] + arr2[i, j];

				}
			}
			Console.Write("\nAdding two matrices: \n");
			for (i = 0; i < n; i++)
			{
				Console.Write("\n");
				for (j = 0; j < n; j++)
					Console.Write("{0}\t", arr3[i, j]);
			}
			Console.Write("\n\n");


		}
	}
}