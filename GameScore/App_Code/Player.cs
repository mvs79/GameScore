using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScore.App_Code
{
    /// <summary>
    /// Player class for the GameScoreApp
    /// </summary>
    public class Player : Person
    {
        #region Enum
        public enum ScoreValue
        {
            TopScorer = 1,
            HighScorer = 2,
            MiddleScoer = 3,
            LowScorer = 4           
        }
        #endregion
        #region Constructor
        /// <summary>
        /// Constructor for Player
        /// </summary>
        /// <param name="name"></param>
        /// <param name="points"></param>
        /// <param name="minusPoints"></param>
        public Player(string name, int minusPoints, int points)
        {
            this.Name = name;
            this.MinusPoints = minusPoints;
            this.Points = points - minusPoints;
            this.ScorePoints = this.GetScorePoints(points, minusPoints);
        }
        #endregion
        #region Properties
        /// <summary>
        /// Propertie GameName
        /// </summary>
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        /// <summary>
        /// Propertie _Points
        /// </summary>
        private int _Points;
        public int Points
        {
            get { return _Points; }
            set { _Points = value; }
        }

        /// <summary>
        /// Propertie MinusPoints
        /// </summary>
        private int _MinusPoints;
        public int MinusPoints
        {
            get { return _MinusPoints; }
            set { _MinusPoints = value; }
        }

        /// <summary>
        /// Propertie ScorePoints
        /// </summary>
        private int _ScorePoints;
        public int ScorePoints
        {
            get { return _ScorePoints; }
            set { _ScorePoints = value; }
        }

        #endregion

        #region Methods
        /// <summary>
        /// Get the Scorepoints of every Player
        /// </summary>
        /// <param name="points"></param>
        /// <param name="minusPoints"></param>
        /// <returns></returns>
        public int GetScorePoints(int points, int minusPoints)
        {
            if (points > minusPoints)
            {
                ScorePoints = 2;
            }
            else if (points < minusPoints)
            {
                ScorePoints = 0;
            }
            else
            {
                ScorePoints = 1;
            }
            return ScorePoints;

        }

        public static void GetArray()
        {
            int[] array = new int[5] { 1,2,3,4,5};
            try
            {
                int value = array[6];
                Debug.WriteLine(value);
            }
            catch (TomcatException ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        public static int GetDividebyZero()
        {
            int value1 = 0;
            int value2 = 15;
            if(value1 == 0)
            {
                throw new DivideByZeroException();
            }

            return value1 + value2;

        }
        #endregion

    }
}
