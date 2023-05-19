using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hristiyan_60
{
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public List<string> Goals { get; set; }
        public string Result { get; set; }
        public Team Winner { get; set; }

        public void PrintResult()
        {
            Console.WriteLine("Game Result:");
            Console.WriteLine("Team 1: " + Team1.Name);
            Console.WriteLine("Team 2: " + Team2.Name);
            Console.WriteLine("Result: " + Result);
            Console.WriteLine("Winner: " + Winner.Name);
            Console.WriteLine("Goals:");
            foreach (string goal in Goals)
            {
                Console.WriteLine(goal);
            }
        }
    }
}
