using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    interface IGame
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
