using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace baseballproject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamsController : ControllerBase
    {
         private readonly TeamsService _data;
        public TeamsController(TeamsService dataFromService){
            _data = dataFromService
        }

        [HttpGet]
        [Route("GetTeamsByTeamsName/{TeamsName}")]
         public IEnumerable<TeamsModel> GetTeamsByTeamsName(string TeamsName){
            return _data.GetTeamsByTeamsName(TeamsName);
        }

        [HttpGet]
        [Route("GetTeamsByOriginatedFrom/{OriginatedFrom}")]
        public IEnumerable<TeamsModel> GetTeamsByOriginatedFrom(string OriginatedFrom){
            return _data.GetTeamsByOriginatedFrom(OriginatedFrom);
        }

        [HttpGet]
        [Route("GetTeamsByWhereAreTheyNow/{ WhereAreTheyNow}")]
        public IEnumerable<TeamsModel> GetTeamsByWhereAreTheyNow(string  WhereAreTheyNow){
            return _data.GetTeamsByWhereAreTheyNow(WhereAreTheyNow);
        }

        [HttpGet]
        [Route("GetTeamsByYearStarted/{YearStarted}")]
        public IEnumerable<TeamsModel> GetTeamsByYearStarted(string YearStarted){
            return _data.GetTeamsByYearStarted(YearStarted);
        }

        [HttpGet]
        [Route("GetTeamsByWorldSeriesWon/{WorldSeriesWon}")]
        public IEnumerable<TeamsModel> GetTeamsByWorldSeriesWon(string WorldSeriesWon){
            return _data.GetTeamsByWorldSeriesWon(WorldSeriesWon);
        }

        [HttpGet]
        [Route("GetTeamsByPastNames/{PastNames}")]
        public IEnumerable<TeamsModel> GetTeamsByPastNames(string PastNames){
            return _data.GetTeamsByPastNames(PastNames);
        }

        [HttpGet]
        [Route("GetTeamsBySuperStars/{SuperStars}")]
        public IEnumerable<TeamsModel> GetTeamsBySuperStars(string SuperStars){
            return _data.GetTeamsBySuperStars(SuperStars);
        }

        [HttpGet]
        [Route("GetTeamsBySuperStarEra/{SuperStarEra}")]
        public IEnumerable<TeamsModel> GetTeamsBySuperStarEra(string SuperStarEra){
            return _data.GetTeamsBySuperStarEra(SuperStarEra);
        }

        [HttpGet]
        [Route("GetTeamsByPastMascot/{PastMascot}")]
        public IEnumerable<TeamsModel> GetTeamsByPastMascot(string PastMascot){
            return _data.GetTeamsByPastMascot(PastMascot);
        }

        [HttpGet]
        [Route("GetTeamsByNewMascot/{NewMascot}")]
        public IEnumerable<TeamsModel> GetTeamsByNewMascot(string NewMascot){
            return _data.GetTeamsByNewMascot(NewMascot);
        }

        [HttpGet]
        [Route("GetTeamsByHallOfFamers/{HallOfFamers}")]
        public IEnumerable<TeamsModel> GetTeamsByHallOfFamers(string HallOfFamers){
            return _data.GetTeamsByHallOfFamers(HallOfFamers);
        }

        [HttpGet]
        [Route("GetTeamsByPastBallPark/{PastBallPark}")]
        public IEnumerable<TeamsModel> GetTeamsByPastBallPark(string PastBallPark){
            return _data.GetTeamsByPastBallPark(PastBallPark);
        }

        [HttpGet]
        [Route("GetTeamsByPresentBallPark/{PresentBallPark}")]
        public IEnumerable<TeamsModel> GetTeamsByPresentBallPark(string PresentBallPark){
            return _data.GetTeamsByPresentBallPark(PresentBallPark);
        }

        [HttpGet]
        [Route("GetTeamsByOriginalOwners/{OriginalOwners}")]
        public IEnumerable<TeamsModel> GetTeamsByOriginalOwners(string OriginalOwners){
            return _data.GetTeamsByOriginalOwners(OriginalOwners);
        }

        [HttpGet]
        [Route("GetTeamsByCurrentOwners/{CurrentOwners}")]
        public IEnumerable<TeamModel> GetTeamsByCurrentOwners(string CurrentOwners){
            return _data.GetTeamsByCurrentOwners(CurrentOwners);
        }
    }
}