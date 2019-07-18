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
            ConsoleOutput ConsoleOutputs = new ConsoleOutput();
            ConsoleInput userInputs = new ConsoleInput();
            UserInformation playerInformation = new UserInformation();

            userInputs = ConsoleOutputs.GameStartUp();

        }
    }
}
