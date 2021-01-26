using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    class Game:IGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
