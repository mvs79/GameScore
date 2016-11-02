using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScore.App_Code
{
    public class Games
    {
        #region Constructor
        /// <summary>
        /// Constructor for Games
        /// </summary>
        /// <param name="game"></param>
        public Games(Game game)
        {
            this.Game = Game;
        }
        public Games()
        {

        }
        #endregion
        #region
        /// <summary>
        /// Propertie of Game
        /// </summary>
        private Game _Game;
        public Game Game
        { get { return _Game; }
          set { _Game = value; }
        }

        /// <summary>
        /// Propertie of GameList
        /// </summary>
        private List<Game> _GameList;
        public List<Game> GameList
        {
            get { return _GameList = new List<Game>(); }
            set { _GameList = new List<Game>(); }
        }
        #endregion

    }
}
