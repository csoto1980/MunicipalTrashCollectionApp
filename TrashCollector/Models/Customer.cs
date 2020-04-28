using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }

        [Display(Name = "Pickup Day")]
        public DayOfWeek PickupDay { get; set; }

        [Display(Name = "One-time Pickup")]
        public DayOfWeek? OneTimePickup { get; set; }

        [Display(Name = "Suspend Account?")]
        public bool SuspendAccount { get; set; }

        [Display(Name = "Suspend Start Date")]
        public string SuspendStart { get; set; }

        [Display(Name = "Suspend End Date")]
        public string SuspendEnd { get; set; }

        public double Balance { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

    }

}
