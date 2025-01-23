using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Position in the tournament
        /// </summary>
        public int PlaceNUmber { get; set; }

        /// <summary>
        /// 1st Place, 2nd Place, 3rd Place, etc.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Fixed amount of prize
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Prize percentage
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
