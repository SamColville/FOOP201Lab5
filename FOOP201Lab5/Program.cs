using System;

namespace FOOP201Lab5
{
    class Program
    {
        static public string formatString = "{0,-15}{1,-8}{2,-8}{3,-8}{4,-8}{5,-8}{6,-8}";

        static void Main(string[] args)
        {
            
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

            DisplayTable(teams);

            SligoRovers.AddResult(Team.Result.Win);
            FinnHarps.AddResult(Team.Result.Loose);
            FinnHarps.AddResult(Team.Result.Draw);
            GalwayUnited.AddResult(Team.Result.Win);
            Dundalk.AddResult(Team.Result.Loose);

            DisplayTable(teams);

            Array.Sort(teams);
            DisplayTable(teams);

            Array.Reverse(teams);
            DisplayTable(teams);

            Console.ReadKey();
        }

        static void DisplayTable(Team[] teams)
        {
            Console.WriteLine(formatString, "Team Name", "Manager", "Points", "Wins", "Draws", "Losses", "Played");
            foreach (var t in teams)
            {
                Console.WriteLine(t.ToString());
            }
            Console.WriteLine("");
        }
    }

    class Team :IComparable
    {
        static public string formatString = "{0,-15}{1,-8}{2,-8}{3,-8}{4,-8}{5,-8}{6,-8}";
        public Team(string _teamName) : this("TeamName", "AnOther")
        {
            teamName = _teamName;
        }
        public Team(string _teamName, string _manager)
        {
            teamName = _teamName;
            manager = _manager;
        }
        public Team() :this("TeamName", "AnOther")
        {
        }

        private string manager;
        public string Manager { get { return manager; } }
        private string teamName;
        public string TeamName { get { return teamName; } }
        private int wins;
        public int Wins { get { return wins; } set { wins = value; } } 
        private int losses;
        public int Losses { get { return losses; } set { losses = value; } }
        private int draws;
        public int Draws { get { return draws; } set { draws = value; } }
        private int points;
        public int Points { get { return points; } set { points = value; } }
        private int games;
        public int Games { get { return games; } set { games = value; } }

        public enum Result
        {
            Win, Draw, Loose
        }

        public void AddResult(Result result)
        {
            switch(result)
            {
                case Result.Win:
                    Wins++;
                    Games++;
                    Points += 3;
                    break;
                case Result.Loose:
                    Losses++;
                    games++;
                    break;
                case Result.Draw:
                    Draws++;
                    Points++;
                    Games++;
                    break;
                default:
                    break;
            }
        }

        public override string ToString()
        {
            //Console.WriteLine(formatString, "Team Name", "Points", "Wins", "Draws", "Losses", "Played");
            return string.Format(formatString, TeamName, Manager, Points, Wins, Draws, Losses, Games);
        }

        int IComparable.CompareTo(object obj)
        {
            Team that = (Team)obj;
            return that.Points.CompareTo(this.Points);
            throw new NotImplementedException();
        }
    }
}
