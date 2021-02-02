using System;

namespace GameProject
{
	class Program
	{
		static void Main(string[] args)
		{
			GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
			gamerManager.Add(new Gamer { Id = 1, FirstName = "Nisa", LastName = "Küçükkömürcü",BirthYear= 1988,IdentityNumber= 123456789 });
		}
	}

	
}
