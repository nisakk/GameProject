using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class CampaingManager : ICampaingServise
	{
		public void Add(Campaing campaing)
		{
			Console.WriteLine(campaing.CampaingName + "Kampanya Eklendi.");
		}

		public void Delete(Campaing campaing)
		{
			Console.WriteLine(campaing.CampaingName + "Kampanya Silindi.");
		}

		public void Update(Campaing campaing)
		{
			Console.WriteLine(campaing.CampaingName+ "Kampanya Güncellendi.");
		}
	}
}
