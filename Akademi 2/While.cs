using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademi_2
{
	internal static class While
	{
		public static void DegerAl(int min, int max)
		{
			Console.WriteLine($"{min}-{max} arasinda bir deger giriniz");
			int deger =Convert.ToInt32(Console.ReadLine());

			while (deger < min || deger>max)
			{
                Console.WriteLine($"girdiğiniz deger : {deger} ,{min}-{max} arasinda değildi tekrar deneyiniz");
				deger = Convert.ToInt32(Console.ReadLine());
			}

            Console.WriteLine("Deger Dogru Aralıkta ");
		}
	}
}
