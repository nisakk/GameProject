using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class UserValidationManager : IUserValidationService
	{
		public bool Validate(Gamer gamer)
		{
			if (gamer.Id==1 && gamer.BirthYear == 1988 && gamer.FirstName == "Nisa" && gamer.LastName == "Küçükkömürcü" && gamer.IdentityNumber == 123456789)
			{
				return (true);
			}
			else
			{
				return (false);
			}
		}
	}
}
