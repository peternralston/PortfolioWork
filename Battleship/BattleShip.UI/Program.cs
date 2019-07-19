using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            SetUpWorkFlow setUp = new SetUpWorkFlow();
            setUp.Start();
            GamePlayWorkFlow playGame = new GamePlayWorkFlow();
            playGame.Start(setUp.GameState);
        }
    }
}
