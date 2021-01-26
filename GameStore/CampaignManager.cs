using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    class CampaignManager : ICampaignManager
    {
        public void Add(IGame game)
        {
            Console.WriteLine(game.Name + "  isimli oyun %20 indirimde!");
        }

        public void Delete(IGame game)
        {
            Console.WriteLine(game.Name + " isimli oyun indirimi kaldırıldı.");
        }

        public void Update(IGame game)
        {
            Console.WriteLine(game.Name + "  isimli oyun artık %30 indirimde!");
        }
    }
}