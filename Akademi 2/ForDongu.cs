using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademi_2
{
	internal static class ForDongu
	{
		public static void ToplaRakam(int sayi)
		{
			string sayiString = sayi.ToString();
			int toplam = 0;
			for (int i = 0; i < sayiString.Length; i++)
			{
				Console.WriteLine(sayiString[i] + " " + i);
				int temp = Convert.ToInt32(sayiString[i].ToString()); // 'char ' şeklinde aldiği için to string yapip sayiya cevirdim 
				toplam += temp;
			}
			Console.WriteLine("Rakamların toplami : " + toplam);
		}
	}
}
