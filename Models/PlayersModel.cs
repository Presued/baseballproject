using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace baseballproject.Models
{
    public class PlayersModel
    {
        public int Id { get; set; }
        
        public string? Name { get; set; }

        public string? Height { get; set; }

        public string? Weight { get; set; }

        public string? Birthday { get; set; }

        public string? Age { get; set; }

        public string? ThrowingHand { get; set; }

        public string? HittingHand { get; set; }

        public string? BirthPlace { get; set; }

        public string? CollegeAttened { get; set; }

        public string? YearDrafted { get; set; }

        public string? DraftRound { get; set; }

        public string? DraftPick { get; set; }

        public string? OriginalTeam { get; set; }

        public string? GoldenGlove { get; set; }

        public string? SilverSlugger { get; set; }

        public string? AllStar { get; set; }

        public string? SwitchHitter { get; set; }

        public string? HomeRuns { get; set; }

        public string? RBI { get; set; }

        public string? Doubles { get; set; }

        public string? Triples { get; set; }

        public string? LifeTimeHomeRuns { get; set; }

        public string? LifeTimeRBI { get; set; }

        public string? LifeTimeDoubles { get; set; }

        public string? LIfeTimeTriples { get; set; }

        public PlayersModel(){}

    }
}