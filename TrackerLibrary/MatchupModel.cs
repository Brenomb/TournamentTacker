using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the list of teams that are playing in this matchup.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represents the winner of the matchup.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents the round of the matchup.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
