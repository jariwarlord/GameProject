using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class NewEStateValidationManager : IUserValidationService
    {
        public bool validate(Player player)
        {
            return true;
        }
    }
}
