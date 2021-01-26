using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    class PlayerManager:IPlayerManager
    {
        public void Add(IPlayer player)
        {

            Console.WriteLine(player.Name + " isimli oyuncu eklendi.");

        }
        public void Update(IPlayer player)
        {

            Console.WriteLine("Oyuncu Id : ");
            player.Id = Console.Read();
            Console.WriteLine("Oyuncu Adi : ");
            player.Name = Convert.ToString(Console.Read());
            Console.WriteLine("Oyuncu Soyadi : ");
            player.LastName = Convert.ToString(Console.Read());
            Console.WriteLine("Oyuncu Kullanici Adi : ");
            player.UserName = Convert.ToString(Console.Read());
            Console.WriteLine("Oyuncu Parola : ");
            player.Password = Convert.ToString(Console.Read());
            Console.WriteLine("Oyuncu bilgileri guncellendi.");

        }
        public void Delete(IPlayer player)
        {
            Console.WriteLine("Oyuncu silindi.");
        }
    }
}
