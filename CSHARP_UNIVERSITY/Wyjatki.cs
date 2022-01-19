using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_UNIVERSITY
{
	internal class Wyjatki
	{
		public void generateArithmeticException()
		{
			try
			{
				int liczba1 = 10, liczba2 = 0;
				Console.WriteLine(liczba1 / liczba2);
			}

			catch (ArithmeticException e)
			{
				Console.WriteLine(e.Message);
			}

			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		public int[] bubbleSort(int[] array)
		{

			int length = array.Length;

			int temp = array[0];
			try
			{
				for (int i = 0; i < length; i++)
				{
					for (int j = i + 1; j < length; j++)
					{
						if (array[i] > array[j])
						{
							temp = array[i];

							array[i] = array[j];

							array[j] = temp;
						}
					}
				}
			}

			catch (IndexOutOfRangeException e)	
			{
				Console.WriteLine(e.Message);
			}	
			return array;
		}


	}
}
