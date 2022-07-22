using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                id = 1,
                YearOfBirth = 2002,
                Name = "KEREM",
                LastName = "KAPLAN",
                IdentityNumber = 12342
            });
        }
    }
}
