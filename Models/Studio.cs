using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Avery_MIS4200.Models
{
    public class Studio
    {
        
        public int StudioID { get; set; }
        public string StudioName { get; set; }
        public string Budget { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<Actors> Actors { get; set; }
    }
}