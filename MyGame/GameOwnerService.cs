using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    interface IGameOwnerService
    {

         void OwnGame(Game game, Gamer gamer);
    }
}
