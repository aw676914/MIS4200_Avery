using Avery_MIS4200.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Avery_MIS4200.DAL
{

    public class MovieContext : DbContext
    {
        public MovieContext() : base("name=DefaultConnection")
        {
          
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Movies> Movie { get; set; }
        public DbSet<TvShows> TvShows { get; set; }
        public DbSet<Studio> Studio { get; set; }
        public DbSet<Actors> Actors { get; set; }

        public System.Data.Entity.DbSet<Avery_MIS4200.Models.Movies> Movies { get; set; }
    }
}
