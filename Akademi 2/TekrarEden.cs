using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademi_2
{
	internal static class TekrarEden
	{
		public static void TekrarSayi(int[] dizi)
		{
			Dictionary<int, int> tekrarSayilari = new Dictionary<int, int>();

			foreach (int eleman in dizi)
			{
				if (tekrarSayilari.ContainsKey(eleman))
					tekrarSayilari[eleman]++;
				else
					tekrarSayilari[eleman] = 1;
			}

			Console.WriteLine("Tekrar eden elemanlar:");
			foreach (var item in tekrarSayilari)
			{
				if (item.Value > 1)
					Console.WriteLine($"Eleman: {item.Key}, Tekrar Sayısı: {item.Value}");
			}

		}
	}
}
