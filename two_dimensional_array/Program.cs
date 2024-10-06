using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace two_dimensional_array
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите количество строк: ");
			int rows = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите количество элементов строки :");
			int cols = Convert.ToInt32(Console.ReadLine());

			int[,] i_arr_2 = new int[rows, cols];

			//int[] m1 = new int[1000];

			//Console.WriteLine(i_arr_2.Rank);
			Random rand = new Random(0);
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					i_arr_2[i, j] = rand.Next(100);
				}
			}
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					Console.Write(i_arr_2[i, j] + "\t");
				}

				Console.WriteLine();

			}

			Console.WriteLine("Отсартированный массив: ");


			int sum2 = 0;
				for (int i = 0; i < rows; i++)

					for (int j = 0; j < cols; j++)
						sum2 += i_arr_2[i, j];

				Console.WriteLine("Сумма массива: " + sum2);
				Console.WriteLine("Среднее арифметическое массива: " + sum2 / i_arr_2.Length);
				//Console.WriteLine(i);
			}
		}
	}

