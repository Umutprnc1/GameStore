using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    interface IPlayerManager
    {
        void Add(IPlayer player);
        void Update(IPlayer player);
        void Delete(IPlayer player);
    }
}
