using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    interface ICampaignManager
    {
        void Add(IGame game);
        void Update(IGame game);
        void Delete(IGame game);
    }
}
