using System;

namespace FOOP201Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Team
    {
        public Team(string _teamName)
        {
            TeamName = _teamName;
        }
        public Team()
        {

        }

        private string teamName;
        public string TeamName { get { return teamName; } }
        private readonly int wins;
        public int Wins { get { return wins; } }
        private readonly int losses;
        public int Losses { get { return losses; } }
        private readonly int draws;
        public int Draws { get { return draws; } }

    }
}
