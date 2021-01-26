using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    interface IGameManager
    {
        void Add(IGame game);
        void Update(IGame game);
        void Delete(IGame game);
        void GetGame(IPlayer player, IGame game);
    }
}
