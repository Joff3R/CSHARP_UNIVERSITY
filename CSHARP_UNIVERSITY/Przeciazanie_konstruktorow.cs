using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_UNIVERSITY
{
	internal class Przeciazanie_konstruktorow
	{
		public double liczba;
		public char znak;

		public Przeciazanie_konstruktorow(double first)
		{
		}

		public Przeciazanie_konstruktorow(char first)
		{
		}

		public Przeciazanie_konstruktorow(double first, char second)
		{
		}

		public Przeciazanie_konstruktorow(double a, double b)
		{
			while (a != b)
			{
				if (a > b)
					a -= b;
				else
					b -= a;
			}
			Console.WriteLine(a);
		}

		public Przeciazanie_konstruktorow(int[] tablica, int zakres, int dokad)
		{
			int i, j;

			for (i = 1; i <= zakres; i++) tablica[i] = i;

			//algorytm - sito eratostenesa
			for (i = 2; i <= dokad; i++)
			{
				if (tablica[i] != 0)
				{
					j = i + i;
					while (j <= zakres)
					{
						tablica[j] = 0;
						j += i;
					}
				}
			}


			Console.WriteLine("Liczby pierwsze z zakresu od 1 do " + zakres);
			for (i = 2; i <= zakres; i++)
				if (tablica[i] != 0)
					Console.WriteLine(i + ", ");
		}

	}
}
