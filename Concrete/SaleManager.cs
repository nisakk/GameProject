using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class SaleManager : ISaleService
	{
		public void Buy(Sale sale, Gamer gamer)
		{
			Console.WriteLine(sale.GameName + ": "+ sale.GamePrice + "satın alındı.");
		}

		public void Delete(Gamer gamer)
		{
			Console.WriteLine("Hesabınız silinmiştir.");
		}
	}
}
