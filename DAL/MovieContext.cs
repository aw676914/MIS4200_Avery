using Avery_MIS4200.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Avery_MIS4200.DAL
{

    public class NovieContext : DbContext
    {
        public NovieContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<Movies> Movie { get; set; }
        public DbSet<TvShows> TvShows { get; set; }
        public DbSet<Studio> Studio { get; set; }
        public DbSet<Actors> Actors { get; set; }

        public System.Data.Entity.DbSet<Avery_MIS4200.Models.Movies> Movies { get; set; }
    }
}
