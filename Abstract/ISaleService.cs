using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	interface ISaleService
	{
		void Buy(Sale sale, Gamer gamer);
		
		void Delete(Gamer gamer);

	}
}
