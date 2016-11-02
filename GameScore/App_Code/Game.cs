using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScore.App_Code
{
    public class Game
    {
        #region Constructor
        /// <summary>
        /// Constructor for Game
        /// </summary>
        /// <param name="gameName"></param>
        /// <param name="player1"></param>
        /// <param name="player2"></param>
        public Game(string gameName,Player player1,Player player2)
        {
            this.GameName = gameName;
            this.Player1 = player1;
            this.Player2 = player2;
        }
        #endregion
        #region
        /// <summary>
        /// Propertie GameName
        /// </summary>
        private string _GameName;
        public string GameName
        {
            get { return _GameName; }
            set { _GameName = value; }
        }
        /// <summary>
        /// Propertie for Player1
        /// </summary>
        private Player _Player1;
        public Player Player1
        {
            get { return _Player1; }
            set { _Player1 = value; }
        }

        /// <summary>
        /// Propertie for Player2
        /// </summary>
        private Player _Player2;
        public Player Player2
        {
            get { return _Player2; }
            set { _Player2 = value; }
            
        }

        /// <summary>
        /// Propertie for a List of Players
        /// </summary>
        private IEnumerable<Player> _PlayerList;
        public IEnumerable<Player> PlayerList
        {
            get { return _PlayerList; }
            set { _PlayerList = value; }
        }
        #endregion
    }
}
