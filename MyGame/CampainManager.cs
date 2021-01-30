using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class CampainManager : ICampainService
    {
        public void CampainBuy(Game game, Campain campain, Gamer gamer)
        {
            Console.WriteLine(game.GameName + " oyununu " + campain.CampainName + " sayesinde " + campain.CampainPrice + " indirim tutarı ile " + gamer.GamerFirstName + gamer.GamerLastName + " satın almıştır");
        }
    }
}
