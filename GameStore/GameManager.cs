using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    class GameManager : IGameManager
    {
        List<IGame> games = new List<IGame>();
        public void Add(IGame game)
        {
            Console.WriteLine("========= OYUN EKLEME =========");
        }

        public void Delete(IGame game)
        {
            Console.WriteLine("========= OYUN EKLEME =========");
            Console.WriteLine("Oyun eklendi.");
        }
        public void Update(IGame game)
        {
            Console.WriteLine("========= OYUN GUNCELLEME =========");
            Console.WriteLine("Oyun Id : ");
            game.Id = Console.Read();
            Console.WriteLine("Oyun adi : ");
            game.Name = Convert.ToString(Console.Read());
            Console.WriteLine("Oyun guncellendi.");
        }
        public void GetGame(IPlayer player, IGame game)
        {
            games.Add(game);
            Console.WriteLine(player.Name + " oyuncusu " + game.Name + " oyununu satin aldi.");
        }
    }
}
