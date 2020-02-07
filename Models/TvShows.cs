using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avery_MIS4200.Models
{
    public class TvShows
    {
        public int TvShowsID { get; set; }
        public string Genre { get; set; }
        public string MovieName { get; set; }
        public string DirectorFirstName { get; set; }
        public string DirectorLastName { get; set; }
        public DateTime MovieMade { get; set; }

        public ICollection<Studio> Studio { get; set; }

        public int MovieID { get; set; }
        public virtual Movies Movies { get; set; }
    }
}