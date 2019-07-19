using System;

namespace BattleShip.UI
{
    internal class GameState
    {
        public string PlayerOneName { get; set; }
        public string PlayerTwoName { get; set; }

        public void SetPlayerOneName()
        {
            Console.WriteLine("Player one, please enter your name");
            PlayerOneName = Console.ReadLine();
            Console.WriteLine($"{PlayerOneName}, Welcome to the Game.");
            Console.ReadKey();
            
        }
    }
}