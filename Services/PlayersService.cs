using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace baseballproject.Services
{
    public class PlayersService
    {
        private readonly DataContext _context;
        public PlayersServic(DataContext context){
            _context = context;
        }
    }
}