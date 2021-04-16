using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjects
{
    public class UserValidationManager : IUserValidationService
    {
        

        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2001
                && gamer.FirstName == "TAYLAN"
                && gamer.LastName == "KALKAN"
                && gamer.IdentityNumber == 123456
                && gamer.Id == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
