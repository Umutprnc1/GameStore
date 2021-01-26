using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    interface IPlayer
    {
        int Id { get; set; }
        string Name { get; set; }
        string LastName { get; set; }
        string BirthDate { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        List<IGame> games { get; set; } // Kullanicinin satin aldigi oyunlar listesi

    }
}
