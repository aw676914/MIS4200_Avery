using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations

namespace Avery_MIS4200.Models
{
    public class Studio
    {
        [Key]
        public int StudioID { get; set; }
        public string StudioName { get; set; }
        public decimal Budget { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<Actors> Actors { get; set; }
    }
}