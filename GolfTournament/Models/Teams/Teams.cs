using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GolfTournament.Models.TeamInfomation
{
    public class Teams
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// id of the tournament the team is playing in
        /// </summary>
        public Tournaments Tournament { get; set; }
        /// <summary>
        /// Name of the team
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// calculated average age of the team members used to see if team qualifies for senior flight
        /// </summary>
        public double AvgAge { get; set; }

    }
}
