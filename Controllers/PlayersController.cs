using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace baseballproject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayersController : ControllerBase
    {
        private readonly PlayersService _data;
        public PlayersController(PlayersService dataFromService){
            _data = dataFromService
        }

        [HttpGet]
        [Route("GetPlayersByName/{Name}")]
        public IEnumerable<PlayersModel> GetPlayersByName(string Name){
            return _data.GetPlayersByName(Name);
        }

        [HttpGet]
        [Route("GetPlayersByHeight/{Height}")]
        public IEnumerable<PlayersModel> GetPlayersByHeight(string Height){
            return _data.GetPlayersByHeight(Height);
        }

        [HttpGet]
        [Route("GetPlayersByWeight/{Weight}")]
        public IEnumerable<PlayersModel> GetPlayersByWeight(string Weight){
            return _data.GetPlayersByWeight(Weight);
        }

        [HttpGet]
        [Route("GetPlayersByBirthday/{Birthday}")]
        public IEnumerable<PlayersModel> GetPlayersByBirthday(string Birthday){
            return _data.GetPlayersByBirthday(Birthday);
        }

        [HttpGet]
        [Route("GetPlayersByAge/{Age}")]
        public IEnumerable<PlayersModel> GetPlayersByAge(string Age){
            return _data.GetPlayersByAge(Age);
        }

        [HttpGet]
        [Route("GetPlayersByThrowingHand/{ThrowingHand}")]
        public IEnumerable<PlayersModel> GetPlayersByThrowingHand(string ThrowingHand){
            return _data.GetPlayersByThrowingHand(ThrowingHand);
        }

        [HttpGet]
        [Route("GetPlayersByHittingHand/{ HittingHand}")]
        public IEnumerable<PlayersModel> GetPlayersByHittingHand(string HittingHand){
            return _data.GetPlayersByHittingHand(HittingHand);
        }

        [HttpGet]
        [Route("GetPlayersByBirthPlace/{BirthPlace}")]
        public IEnumerable<PlayersModel> GetPlayersByBirthPlace(string BirthPlace){
            return _data.GetPlayersByBirthPlace(BirthPlace);
        }

        [HttpGet]
        [Route("GetPlayersByCollegeAttened/{CollegeAttened}")]
        public IEnumerable<PlayersModel> GetPlayersByCollegeAttened(string CollegeAttened){
            return _data.GetPlayersByCollegeAttened(CollegeAttened);
        }

        [HttpGet]
        [Route("GetPlayersByYearDrafted/{YearDrafted}")]
        public IEnumerable<PlayersModel> GetPlayersByYearDrafted(string YearDrafted){
            return _data.GetPlayersByYearDrafted(YearDrafted);
        }

        [HttpGet]
        [Route("GetPlayersByDraftRound/{DraftRound}")]
        public IEnumerable<PlayersModel> GetPlayersByDraftRound(string DraftRound){
            return _data.GetPlayersByDraftRound(DraftRound);
        }

        [HttpGet]
        [Route("GetPlayersByDraftPick/{DraftPick}")]
        public IEnumerable<PlayersModel> GetPlayersByDraftPick(string DraftPick){
            return _data.GetPlayersByDraftPick(DraftPick);
        }

        [HttpGet]
        [Route("GetPlayersByOriginalTeam/{OriginalTeam}")]
        public IEnumerable<PlayersModel> GetPlayersByOriginalTeam(string OriginalTeam){
            return _data.GetPlayersByOriginalTeam(OriginalTeam);
        }

        [HttpGet]
        [Route("GetPlayersByGoldenGlove/{GoldenGlove}")]
        public IEnumerable<PlayersModel> GetPlayersByGoldenGlove(string GoldenGlove){
            return _data.GetPlayersByGoldenGlove(GoldenGlove);
        }

        [HttpGet]
        [Route("GetPlayersBySilverSlugger/{SilverSlugger}")]
        public IEnumerable<PlayersModel> GetPlayersBySilverSlugger(string SilverSlugger){
            return _data.GetPlayersBySilverSlugger(SilverSlugger);
        }

        [HttpGet]
        [Route("GetPlayersByAllStar/{AllStar}")]
        public IEnumerable<PlayersModel> GetPlayersByAllStar(string AllStar){
            return _data.GetPlayersByAllStar(AllStar);
        }

        [HttpGet]
        [Route("GetPlayersBySwitchHitter/{SwitchHitter}")]
        public IEnumerable<PlayersModel> GetPlayersBySwitchHitter(string SwitchHitter){
            return _data.GetPlayersBySwitchHitter(SwitchHitter);
        }

        [HttpGet]
        [Route("GetPlayersByHomeRuns/{HomeRuns}")]
        public IEnumerable<PlayersModel> GetPlayersByHomeRuns(string HomeRuns){
            return _data.GetPlayersByHomeRuns(HomeRuns);
        }

        [HttpGet]
        [Route("GetPlayersByRBI/{RBI}")]
        public IEnumerable<PlayersModel> GetPlayersByRBI(string RBI){
            return _data.GetPlayersByRBI(RBI);
        }

        [HttpGet]
        [Route("GetPlayersByDoubles/{Doubles}")]
        public IEnumerable<PlayersModel> GetPlayersByDoubles(string Doubles){
            return _data.GetPlayersByDoubles(Doubles);
        }

        [HttpGet]
        [Route("GetPlayersByTriples/{Triples}")]
        public IEnumerable<PlayersModel> GetPlayersByTriples(string Triples){
            return _data.GetPlayersByTriples(Triples);
        }

        [HttpGet]
        [Route("GetPlayersByLifeTimeHomeRuns/{LifeTimeHomeRuns}")]
        public IEnumerable<PlayersModel> GetPlayersByLifeTimeHomeRuns(string LifeTimeHomeRuns){
            return _data.GetPlayersByLifeTimeHomeRuns(LifeTimeHomeRuns);
        }

        [HttpGet]
        [Route("GetPlayersByLifeTimeRBI/{LifeTimeRBI}")]
        public IEnumerable<PlayersModel> GetPlayersByLifeTimeRBI(string LifeTimeRBI){
            return _data.GetPlayersByLifeTimeRBI(LifeTimeRBI);
        }

        [HttpGet]
        [Route("GetPlayersByLifeTimeDoubles/{LifeTimeDoubles}")]
        public IEnumerable<PlayersModel> GetPlayersByLifeTimeDoubles(string LifeTimeDoubles){
            return _data.GetPlayersByLifeTimeDoubles(LifeTimeDoubles);
        }

        [HttpGet]
        [Route("GetPlayersByLIfeTimeTriples/{ LIfeTimeTriples}")]
        public IEnumerable<PlayersModel> GetPlayersByLIfeTimeTriples(string LIfeTimeTriples){
            return _data.GetPlayersByLIfeTimeTriples( LIfeTimeTriples);
        }
    }
} 