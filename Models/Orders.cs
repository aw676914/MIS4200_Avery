using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Avery_MIS4200.Models
{
    public class Orders
    {
        [Key]
        public int orderNum { get; set; }

    }
}