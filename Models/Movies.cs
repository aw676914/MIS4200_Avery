﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avery_MIS4200.Models
{
    public class Movies
    {
        public int MovieID { get; set; }
        public string Genre { get; set; }
        public string MovieName { get; set; }
        public string Director { get; set; }
        public DateTime MovieMade { get; set; }

        public ICollection<TvShows> TvShows { get; set; }
    }
}