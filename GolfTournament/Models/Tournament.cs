using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GolfTournament.Models
{
    public class Tournament
    {
        [Key]
        public int TournamentId { get; set; }
        /// <summary>
        /// Id of the course that is being used for the tournament
        /// </summary>
        public int CourseId { get; set; }
        /// <summary>
        /// Date the tournament is being played 
        /// </summary>
        public DateTime ScheduledDate { get; set; }
    }
}
