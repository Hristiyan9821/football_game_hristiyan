using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hristiyan_60
{
    public class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Striker { Name = "Player 1", Number = 6, Age = 23, Height = 183 };
            var player2 = new Striker { Name = "Player 2", Number = 11, Age = 31, Height = 172 };
            var player3 = new Midfield { Name = "Player 3", Number = 14, Age = 27, Height = 178 };
            var player4 = new Midfield { Name = "Player 4", Number = 33, Age = 29, Height = 169 };
            var team = new Team();
            team.Players.Add(player1);
            team.Players.Add(player2);
            var coach = new Coach { Name = "Coach", Age = 46 };
            team.Coach = coach;

            var game = new Game();
            game.Team1 = team;
            game.Result = "4-1";
            game.Goals = new List<string> { "Goal 4", "Goal 1" };

            game.PrintResult();
            Console.WriteLine();
        }
    }
}
