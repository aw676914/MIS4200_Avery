﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avery_MIS4200.Models
{
    public class TvShows
    {
        public int TvShowsID { get; set; }
        public string Genre { get; set; }
        public string TVName { get; set; }
        public string DirectorFirstName { get; set; }
        public string DirectorLastName { get; set; }
        public string Produced { get; set; }

        public ICollection<Studio> Studio { get; set; }

        public int MovieID { get; set; }
        public virtual Movies Movies { get; set; }

        public string FullName { get { return DirectorLastName + ", " + DirectorFirstName; } }
    }
}