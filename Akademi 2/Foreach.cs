using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademi_2
{
	internal static class Foreach
	{
		public static void KategorizeEt(int[] yasDizi)
		{


			foreach (int yas in yasDizi)

		{
				string kategori;

				if (yas >= 0 && yas <= 12)
					kategori = "Çocuk";
				else if (yas >= 13 && yas <= 19)
					kategori = "Genç";
				else if (yas >= 20 && yas <= 64)
					kategori = "Yetişkin";
				else
					kategori = "Yaşlı";

				Console.WriteLine($"Yaş: {yas} - Kategori: {kategori}");
			}
		}
	}
}
