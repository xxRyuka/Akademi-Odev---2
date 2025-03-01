using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademi_2
{

internal static class SayiList
{
	public static void SayilariIsle()
	{
		List<int> sayilar = new List<int>();

		Console.WriteLine("\n Sayıları girin (Durmak için -1 girin):");
		while (true)
		{
			int sayi = int.Parse(Console.ReadLine());
			if (sayi == -1) break;
			sayilar.Add(sayi);
		}

		double ortalama = sayilar.Average();
		sayilar.Sort(); // Sorting algoritmasiyla ugrasacak enerjim yoktu :D

		Console.WriteLine($"Girilen sayıların ortalaması: {ortalama}");
		Console.WriteLine("Küçükten büyüğe sıralama:");
		foreach (var s in sayilar)
		{
			Console.Write(s + " ");
		}
	}
}

}