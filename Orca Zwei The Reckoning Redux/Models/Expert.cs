using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Orca_Zwei_The_Reckoning_Redux.Models
{
    public class Expert
    {
        public int ExpertID { get; set; }
        public string Email { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Home Institution")]
        public string HomeInst { get; set; }
        [Required]
        [Display(Name = "Work Phone")]
        public string WorkPhone { get; set; }
        [Required]
        [Display(Name = "Specialties. (Seperate with a comma.)")]
        public string Specialties  { get; set; }

        public bool Validated { get; set; }
        public bool Vacation { get; set; }
    }
}