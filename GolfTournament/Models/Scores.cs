using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfTournament.Models
{
    public class Scores
    {
        public int ScoreId { get; set; }
        public int Score { get; set; }
        /// <summary>
        /// Team the score is for on the paticular hole
        /// </summary>
        public Teams Teams { get; set; }
        /// <summary>
        /// Hole in which the score was made
        /// </summary>
        public Holes Hole { get; set; }
    }
}
