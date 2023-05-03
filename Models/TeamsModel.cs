using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace baseballproject.Models
{
    public class TeamsModel
    {
        public int Id { get; set; }
        
        public string? TeamsName { get; set; }

        public string? OriginatedFrom { get; set;}

        public string? WhereAreTheyNow { get; set; }

        public string? YearStarted { get; set; }

        public string? WorldSeriesWon { get; set; }

        public string? PastNames { get; set; }

        public string? SuperStars { get; set:}

        public string? SuperStarEra { get: set: }

        public string? PastMascot { get; set; }

        public string? NewMascot { get; set; }

        public string? HallOfFamers { get; set; }

        public string? PastBallPark { get; set; }

        public string? PresentBallPark { get; set; }

        public string? OriginalOwners { get; set; }

        public string? CurrentOwners { get; set; }

        public TeamsModel(){}

    }
}