using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademi_2
{
	internal class NotFiltre
	{
		
			public static void KucukleriSil(List<int> sayilar)
			{
				sayilar.RemoveAll(s => s < 10);

				Console.WriteLine("10'dan küçükler silindi, güncel liste:");
				foreach (var s in sayilar)
				{
					Console.Write(s + " ");
				}
			}
		
	}
}
