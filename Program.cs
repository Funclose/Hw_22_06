using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_22_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>
            {
                new Player("Lionel Messi", "10"),
                new Player("Cristiano Ronaldo", "7"),
                new Player("Kevin De Bruyne", "17"),
                new Player("Virgil van Dijk", "4"),
                new Player("Manuel Neuer", "1")
            };
            FootballTeam team = new FootballTeam("Dream team", players);

            Console.WriteLine($"football team: {team.TeamName}");
            Console.WriteLine($"Players in the {team.TeamName}: ");
            foreach (var play in team)
            {
                Console.WriteLine(play);
            }


        }
    }
}
