using System;

namespace FOOP201Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            string formatString = "{0,-15}{1,-8}{2,-8}{3,-8}{4,-8}{5,-8}";
            Team SligoRovers = new Team("Sligo  Rovers");
            Team FinnHarps = new Team("Finn  Harps");
            Team GalwayUnited = new Team("Galway  United");
            Team DerryCity = new Team("Derry  City");
            Team Dundalk = new Team("Dundalk");
            Team[] teams = new Team[5];
            teams[0] = SligoRovers;
            teams[1] = FinnHarps;
            teams[2] = GalwayUnited;
            teams[3] = DerryCity;
            teams[4] = Dundalk;
            Console.WriteLine(formatString, "Team Name", "Points", "Wins", "Draws", "Losses", "Played");
            foreach (var te in teams)
            {
                Console.WriteLine(formatString, te.TeamName, te.Points, te.Wins, te.Draws, te.Losses, te.Games);
            }

            Console.ReadKey();
        }
    }

    class Team
    {
        public Team(string _teamName)
        {
            teamName = _teamName;
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
        private readonly int points;
        public int Points { get { return points; } }
        private readonly int games;
        public int Games { get { return games; } }

    }
}
