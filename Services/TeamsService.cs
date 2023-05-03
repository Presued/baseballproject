using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace baseballproject.Services
{
    public class TeamsService
    {
        private readonly DataContext _context;
        public TeamsServic(DataContext context){
            _context = context;
        }

        public IEnumerable<TeamsModel> GetTeamsByTeamsName(string TeamsName){
            return _context.TeamsInfo.where(item => item.TeamsName == TeamsName);
        }

        public IEnumerable<TeamsModel> GetTeamsByOriginatedFrom(string OriginatedFrom){
            return _context.TeamsInfo.where(item => item.OriginatedFrom == OriginatedFrom);
        }

        
    }
}