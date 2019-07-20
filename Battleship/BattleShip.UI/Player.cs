using System;
using BattleShip.BLL;
using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;

namespace BattleShip.UI
{
    internal class Player
    {
        private string _name;
        private Board _battlePositions;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        internal void SetBoardPositions()
        {
             // Create a method for prompting, validating, and translating a user's coordinate
            Console.WriteLine($"{_name}, please choose your Battle Positions for your ShipType");
            Console.ReadLine();

            // Display a board

            // Tell what ship they are placing 

            // validate thier inputs

            // update board they are placing

            // cycle through each ship untill all are placed
        }
    }
}