using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Akademi_2
{

internal static class CumleSirala
	{
		public static void CumleyiSirala()
		{
			Console.Write("Bir cümle girin: ");
			string cumle = Console.ReadLine();
			string[] kelimeler = cumle.Split(' ');

			Array.Sort(kelimeler);

			Console.WriteLine("Alfabetik sıralama:");
			foreach (var kelime in kelimeler)
			{
				Console.WriteLine(kelime);
			}
		}
	}

}