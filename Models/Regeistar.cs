using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Avery_MIS4200.Models
{
    public class Regeistar
    {
        [Required]
        public Guid ID { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Display(Name = "Primary Phone")]
        [Phone]
        public string PhoneNumber { get; set; }
        [Display(Name = "Office")]
        public string Studio { get; set; }
        [Display(Name = "Current position")]
        public string Position { get; set; }
        [Display(Name = "Hire Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime hireDate { get; set; }
        
    }
}