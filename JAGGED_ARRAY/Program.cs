using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGGED_ARRAY
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[][] arr_jagget = new int[][]
				{
				new int[]{0, 1, 1, 2 },
				new int[]{3, 5, 8, 13, 21 },
				new int[]{34, 55, 89 },
				new int[]{144, 233, 377, 610, 987}

				};
			for (int i = 0; i < arr_jagget.Length; i++)
			{
				for (int j = 0; j < arr_jagget[i].Length; j++)
				{
					Console.Write(arr_jagget[i][j] + "\t");
				}
				Console.Write("\n");
			}
			int sum = 0;
			for (int i = 0; i < arr_jagget.Length; i++)
			{
				for (int j = 0; j < arr_jagget[i].Length; j++)
				{
					sum += arr_jagget[i][j];
				}
			}

			Console.WriteLine("отсортированный массив: ");




			Console.WriteLine("Сумма массива: " + sum);

			int res = 0;
			for (int i = 0; i < arr_jagget.Length; i++)
			{
					res = sum / arr_jagget.Length;
			}
				Console.WriteLine("Среднее арифметическое массива: "+res);
		}
	}
}
