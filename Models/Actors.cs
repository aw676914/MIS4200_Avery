using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avery_MIS4200.Models
{
    public class Actors
    {
        public int ActorsID { get; set; }
        public decimal ActorsPay { get; set; }
        // the next two properties link the orderDetail to the Order
        public int MovieID { get; set; }
        public int TvShowsID { get; set; }
        public virtual TvShows TvShows { get; set; }
        // the next two properties link the orderDetail to the Product
       
        public int StudioID { get; set; }
        public virtual Studio Studio { get; set; }

    }
}