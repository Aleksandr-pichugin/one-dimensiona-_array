using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_dimensional_array
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите размер массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			//int[] arr= new int[] { 3, 5, 8, 13, 21 };
			int[] arr = new int[n];
			Random rand = new Random(); // 0-seed value
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(100);

			}
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
			Console.WriteLine();

			Console.WriteLine("Отсартированный массив: ");
			Array.Sort(arr);
			foreach (int i in arr)
			{
				Console.Write(i + " ");
			}

			int sum = arr.Sum();// находим сумму массива 
			Console.WriteLine("Сумма массива: " + sum);// Вывод суммы массива
			Console.WriteLine("Среднее арифметическое массива: " + sum / arr.Length);
			Console.WriteLine("Минимальное значение: " + arr[0]);
			int max = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				max=Math.Max(max, arr[i]);
			}
			Console.WriteLine("Максимальное значение: " + max );
		}
	}
}
