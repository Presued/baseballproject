using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace baseballproject.Services.Context
{
    public class DataContext : DbContext
    {
        public DbSet<PlayersModel> PlayerInfo { get; set; }

        public DbSet<TeamsModel> TeamsInfo { get; set; }

        public DataContext(DbContextOptions options): base(options)
        {}

        protected override void OnModelCreating(ModelBuilder builder){
            base.OnModelCreating(builder);
        }
    }
}