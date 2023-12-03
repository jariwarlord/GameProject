using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class PlayerManager : IPlayerService
    {
        private object value;

        public PlayerManager(object value)
        {
            this.value = value;
        }

        public void Add(Player player)
        {
            Console.WriteLine("Kayıt olundu..");
            Console.WriteLine(player.FirstName + " " + player.LastName);
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Kayıt silindi...");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Kayıt güncellendi...");
        }
    }
}
