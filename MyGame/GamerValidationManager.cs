using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class GamerValidationManager : IGamerValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.GamerFirstName=="Ramazan" && gamer.GamerLastName == "Kavlak" && gamer.GamerId == 1 && gamer.GamerTc == "11245235587" && gamer.GamerBirthDay=="21.01.1998" )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
