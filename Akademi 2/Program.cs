using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademi_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ForDongu.ToplaRakam(59);
			While.DegerAl(50, 100);
			int[]  yaslar =  { 5, 16, 25, 70, 12, 19, 40, 65, 80,70 };
			Foreach.KategorizeEt(yaslar);


			string[] kelimeler = { "elma", "armut", "kiraz", "muz", "çilek", "karpuz", "kayısı" };

		EnUzunString.BulEnUzun(kelimeler);
		TekrarEden.TekrarSayi(yaslar);
			CumleSirala.CumleyiSirala();
			//DinamikDizi burda kodlar karişmasin diye testlerini yapmadim
			//ama veri yapıları dersinde bunun gibi bir cok algoritma yazdiğim için dogru oldugundan eminim
			List<int> SayiListe = new List<int>();
			foreach (int i in yaslar)
			{
				SayiListe.Add(i); // Yaslardaki sayilari listeye aktardim
			}
			NotFiltre.KucukleriSil(SayiListe);

			SayiList.SayilariIsle();
			TerstenYaz.EkleTersCevir();
		Console.ReadLine();
		}
	}
}
