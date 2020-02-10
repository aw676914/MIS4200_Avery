using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Avery_MIS4200.Models
{
    public class Actors
    {
        public int ActorsID { get; set; }
        public string ActorsPay { get; set; }
        // the next two properties link the orderDetail to the Order
        public string ActorsFirstname { get; set; }
        public string ActorsLastname { get; set; }
        public int TvShowsID { get; set; }
        public virtual TvShows TvShows { get; set; }
        // the next two properties link the orderDetail to the Product
       
        public int StudioID { get; set; }
        public virtual Studio Studio { get; set; }

        public string FullName { get { return ActorsLastname + ", " + ActorsFirstname; } }

    }
}