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
            SetUserNames(player1, player2);
            SetUpBoards(player1, player2);
            EndOfWorkflow();
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
        }

        public void SetUserNames(Player player1, Player player2) // choose names for players
        {
            player1 = SetUserName(player1);
            player2 = SetUserName(player2);
        }

        private void SetUpBoards(Player player1, Player player2) // set up boards for players
        {
            player1 = SetUpBoard(player1);
            player2 = SetUpBoard(player2);
        }

        private Player SetUpBoard(Player player)
        {
            Console.Clear();
            Console.WriteLine($"{player.GetPlayerName()} Please choose a your positions");
            player.SetBoardPositions();
            return player;

        }

        private Player SetUserName(Player player) 
        {
            Console.WriteLine("Please chose your name...");
            player.SetPlayerName(Console.ReadLine());
            Console.Clear();

            return player;
        }

    }
}