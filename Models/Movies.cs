using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Avery_MIS4200.Models
{
    public class Movies
    {
        [Key]
        public int MovieID { get; set; }
        public string Genre { get; set; }
        public string MovieName { get; set; }
        public string DirectorFirstName { get; set; }
        public string DirectorLastName { get; set; }
        public DateTime MovieMade { get; set; }

        public string FullName { get { return DirectorLastName + ", " + DirectorFirstName; } }


        public ICollection<TvShows> TvShows { get; set; }
    }
}