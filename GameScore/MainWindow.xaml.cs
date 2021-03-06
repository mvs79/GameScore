﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GameScore.App_Code;
using System.Diagnostics;

namespace GameScore
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            //Player.GetArray();
            try
            {
              Player.GetDividebyZero();
            }
            catch (DivideByZeroException ex)
            {
               Console.WriteLine(ex.StackTrace);
              
            }
           
            InitializeComponent();            
        }

            public List<Game> GetGames()
            {
                Player p1 = new Player("Tomcat", 5, 20);
                var score = Player.ScoreValue.HighScorer.ToString();
                Player p2 = new Player("Martin", 10, 30);
                Player p3 = new Player("Matthias", 20, 5);
                Player p4 = new Player("Johannes", 10, 20);
                Game game1 = new Game("GianaSisters", p1, p2);
                Game game2 = new Game("Heimdall", p3, p4);
                Games games = new Games();
                List<Game> gamesListing = games.GameList;
                gamesListing.Add(game1);
                gamesListing.Add(game2);
                return gamesListing;

            }
           
           public Games GetGames(int value)
           {
            Games gamer1 = new Games();
            return gamer1;
            }

        private void button_Click(object sender, RoutedEventArgs e)
        {   
            //List<Game> gamesListing = this.GetGames();
            //dataGrid1.ItemsSource = gamesListing;
        }
    }
}
