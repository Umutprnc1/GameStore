using GameStore;
using System;
using System.Collections.Generic;


namespace GameStore
{
    class Program
    {
        static void Main(string[] args)
        {

            IPlayer player1 = new Player() { Id = 1, Name = "Dilara", LastName = "Yavuz", BirthDate = "13/12/2000", games = { }, UserName = "dilarayvz", Password = "1234" };
            IPlayer player2 = new Player() { Id = 2, Name = "Mert", LastName = "Taş", BirthDate = "06/02/1998", games = { }, UserName = "merttas", Password = "4321" };

            IGame game1 = new Game() { Id = 1, Name = "Valorant" };
            IGame game2 = new Game() { Id = 2, Name = "Rocker League" };

            IPlayerManager playerManager = new PlayerManager();

            IGameManager gameManager = new GameManager();

            ICampaignManager campaignManager = new CampaignManager();

            Console.WriteLine("MENU");
            Console.WriteLine("1-Kayit ol.");
            Console.WriteLine("2-Kayit duzenle.");
            Console.WriteLine("3-Kayit sil.");
            Console.WriteLine("4-Oyun ekle.");
            Console.WriteLine("5-Oyun guncelle.");
            Console.WriteLine("6-Oyunc sil.");
            Console.WriteLine("4-Kampanya ekle.");
            Console.WriteLine("5-Kampanya guncelle.");
            Console.WriteLine("6-Kampanya sil.");
            Console.WriteLine("7-Oyun satin al.");

            int islem = Convert.ToInt32(Console.ReadLine());

            switch (islem)
            {
                case 1:
                    Console.WriteLine("========== OYUNCU KAYIT ISLEMI==========");
                    playerManager.Add(player1);
                    playerManager.Add(player2);
                    break;
                case 2:
                    Console.WriteLine("========== OYUNCU KAYIT DUZENLEME ============");
                    playerManager.Update(player1);
                    break;
                case 3:
                    Console.WriteLine("========== OYUNCU SILME ISLEMI==========");
                    playerManager.Delete(player2);
                    break;
                case 4:
                    Console.WriteLine("========== OYUN EKLEME ISLEMI==========");
                    gameManager.Add(game1);
                    gameManager.Add(game2);
                    break;
                case 5:
                    Console.WriteLine("========== OYUN GUNCELLEME ISLEMI==========");
                    gameManager.Update(game1);
                    break;
                case 6:
                    Console.WriteLine("========== OYUN SILME ISLEMI==========");
                    gameManager.Delete(game2);
                    break;
                case 7:
                    Console.WriteLine("========== KAMPANYA EKLEME ISLEMI==========");
                    campaignManager.Add(game1);
                    gameManager.Add(game2);
                    break;
                case 8:
                    Console.WriteLine("========== KAMPANYA GUNCELLEME ISLEMI==========");
                    campaignManager.Update(game1);
                    break;
                case 9:
                    Console.WriteLine("========== KAMPANYA SILME ISLEMI==========");
                    campaignManager.Delete(game2);
                    break;
                case 10:
                    Console.WriteLine("========== OYUN SATIN ALMA ISLEMI==========");
                    gameManager.GetGame(player1, game2);
                    break;
            }
        }
    }
}