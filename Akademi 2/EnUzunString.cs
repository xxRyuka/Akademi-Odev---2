using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademi_2
{
	internal static class EnUzunString
	{
		public static void BulEnUzun(string[] str)
		{


			string[] kelimeler = { "elma", "armut", "kiraz", "muz", "çilek", "karpuz", "kayısı" };

			string enUzun = kelimeler[0];
			string enKisa = kelimeler[0];

			foreach (string kelime in kelimeler)
			{
				if (kelime.Length > enUzun.Length)
					enUzun = kelime;

				if (kelime.Length < enKisa.Length)
					enKisa = kelime;
			}

			Console.WriteLine($"En uzun kelime: {enUzun}");
			Console.WriteLine($"En kısa kelime: {enKisa}");
		}

	
}
}
