using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new NewEStateValidationManager());
            playerManager.Add( new Player
            {
                Id =1,
                BirthDay = 1999,
                FirstName = "Berke",
                LastName = "Dalar",
                IdentityNumber = 123456789,
            });
            playerManager.Update(new Player
            {
                Id = 2,
                BirthDay = 2000,
                FirstName = "Berkant",
                LastName = "Dalar",
                IdentityNumber = 12345
            });
            Console.WriteLine("Hi");
            Console.ReadLine();
        }
    }
}
