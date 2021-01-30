using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Gamer ekleme kısmı
            Gamer gamer1 = new Gamer { GamerId = 1, GamerFirstName = "Ramazan", GamerLastName = "Kavlak", GamerTc = "11245235587", GamerBirthDay = "21.01.1998" };
            
            GamerManager gamerManager = new GamerManager( new GamerValidationManager());
            gamerManager.Add(gamer1);

            // Game ekleme kısmı

            Game game1 = new Game { GameName = "Counter Strike Global Offensive", GameCost = 78, GameData=5, GameRating=9, GameType="Online Fps" };
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            //oyunu satın alma kısmı

            GameOwnerManager gameOwnerManager = new GameOwnerManager();
            gameOwnerManager.OwnGame(game1, gamer1);

            //campain ile satın alma kısmı

            Campain campain1 = new Campain {CampainName="Efsane Kış İndirimleri", CampainPrice="%25" };
            CampainManager campainManager = new CampainManager();
            campainManager.CampainBuy(game1,campain1,gamer1);


            Console.ReadLine();
        }

        
    }
}
