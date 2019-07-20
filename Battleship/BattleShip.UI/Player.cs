using System;

namespace BattleShip.UI
{
    internal class Player
    {
        private string _playerName;

        public void SetPlayerName(string name)
        {
            _playerName = name;
        }

        public string GetPlayerName()
        {
            return _playerName;
        }

        internal void SetBoardPositions()
        {
            throw new NotImplementedException();
        }
    }
}