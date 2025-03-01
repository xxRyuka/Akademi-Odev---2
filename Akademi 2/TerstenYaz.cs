using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Akademi_2
{

static class TerstenYaz
{
	public static void EkleTersCevir()
	{
		List<string> kelimeler = new List<string>();

		Console.WriteLine("Kelimeleri girin (Çıkmak için 'q' tuşuna basın):");
		while (true)
		{
			string kelime = Console.ReadLine();
			if (kelime.ToLower() == "q") break;
			kelimeler.Add(kelime);
		}


		Console.WriteLine("Tersten yazdırılan liste:");
		foreach (var kelime in kelimeler)
		{
			string reverse = "";
			for (int i = kelime.Length-1; i >= 0; i--)
				{
					reverse+=(kelime[i]);

				}
                Console.WriteLine(reverse);
		}
	}
}

}