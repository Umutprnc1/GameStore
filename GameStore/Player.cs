using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    class Player:IPlayer
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<IGame> games { get; set; }
    }
}
