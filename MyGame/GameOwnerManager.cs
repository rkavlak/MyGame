using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class GameOwnerManager : IGameOwnerService
    {
        public void OwnGame(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.GamerFirstName+ "," + game.GameName + " oyunun satın aldı.");
        }
    }
}
