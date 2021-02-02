using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class GamerManager : IGamerServise
	{
		IUserValidationService _userValidationService;

		public GamerManager(IUserValidationService userValidationService)
		{
			_userValidationService = userValidationService;
		}

		public void Add(Gamer gamer)
		{
			if (_userValidationService.Validate(gamer)== true)
			{

			}
			else
			{
				Console.WriteLine("Doğrulama Başarısız");
			}
			Console.WriteLine("Kaydınız Oluşturuldu");
		}

		public void Delete(Gamer gamer)
		{
			Console.WriteLine("Kaydınız Güncellendi");
		}

		public void Update(Gamer gamer)
		{
			Console.WriteLine("Kaydınız Silindi");
		}
	}
}
