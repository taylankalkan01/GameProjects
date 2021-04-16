using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjects
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer {
                Id = 1,
                BirthYear = 2001,
                FirstName = "TAYLAN",
                LastName = "KALKAN",
                IdentityNumber = 123456
            });
        }
    }
}
