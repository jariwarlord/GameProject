using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class UserValidationManager : IUserValidationService
    {
        public bool validate(Player player)
        {
            if(player.FirstName == "Berke" && player.LastName == "Dalar" &&
                player.BirthDay == 1999 && player.IdentityNumber == 123456789)
            {
                return true;
            }
            return false;
        }
    }
}
