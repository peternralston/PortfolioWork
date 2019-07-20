using System;

namespace BattleShip.UI
{
    internal class SetUpWorkFlow
    {
        Player player1 = new Player();
        Player player2 = new Player();

        internal void Start()
        {
            SplashScreen();
            SetUserNames();
            SetUpBoards();
            EndOfWorkflow(); // remove once workflow is complete
        }

        private void EndOfWorkflow()
        {
            Console.WriteLine("You have reached the end of the workflow"); // remove once workflow is complete
            Console.ReadKey();
        }

        private void SplashScreen() // show a splash screen
        {
            Console.WriteLine("splash!!!");
            Console.ReadKey();
            Console.Clear();
        }

        public void SetUserNames() // choose names for players
        {
            SetUserName(player1);
            SetUserName(player2);
        }

        private void SetUpBoards() // set up boards for players
        {
            Console.WriteLine($"");
            SetUpBoard(player1);
            SetUpBoard(player2);
        }

        private Player SetUpBoard(Player player)
        {
            Console.Clear();
            Console.WriteLine($"{player.Name} Please choose a your Battle Positions");
            player.SetBoardPositions();
            return player;
        }

        private void SetUserName(Player player)
        {
            Console.WriteLine("Please chose your name...");
            player.Name = ("Admeral " + Console.ReadLine());
            Console.WriteLine($"Welcome to the battle field {player.Name}");
            Console.ReadKey();
            Console.Clear();

        }

    }
}