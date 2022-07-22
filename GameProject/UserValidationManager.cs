using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.YearOfBirth == 2002 && gamer.Name == "KEREM" 
                && gamer.LastName == "KAPLAN" && gamer.IdentityNumber == 12342)
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
