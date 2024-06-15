using hw_22_06;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_22_06
{
    internal class FootballTeam : IEnumerable<Player>
    {
        public string TeamName { get; set; }
        private List<Player> Players { get; set; }

        public FootballTeam(string teamName, List<Player> players)
        {
            TeamName = teamName;
            Players = players;
        }

        public IEnumerator<Player> GetEnumerator()
        {
            foreach (var player in Players)
            {
                yield return player;
            }
        }


        IEnumerator IEnumerable.GetEnumerator() 
        {
            return GetEnumerator();
        }
    }
        
}
