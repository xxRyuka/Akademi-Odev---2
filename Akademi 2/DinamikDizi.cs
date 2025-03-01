using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademi_2
{
	internal static class DinamikDizi
	{

		
		public static void DiziyiGenislet(int[] dizi)// string değilde int türünden bi diziyle calısmak istedim
		{
			if (dizi == null)
			{
                Console.WriteLine("Dizi Bos");
			}
			else
			{
				int[] yeniDizi = new int[dizi.Length*2];

			for (int i = 0; i < dizi.Length; i++)
			{
				yeniDizi[i] = dizi[i];
			}
			}
		}
	}
}
