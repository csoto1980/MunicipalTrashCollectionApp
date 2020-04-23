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
        [Required(ErrorMessage ="First Name Required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name Required")]
        public string LastName { get; set; }

        [Display(Name = "Pickup Day")]
        public DayOfWeek PickupDay { get; set; }

        [Display(Name = "One-time Pickup")]
        public DateFormat OneTimePickup { get; set; }

        [Display(Name = "Suspend Start Date")]
        public DateFormat SuspendStart { get; set; }

        [Display(Name = "Suspend End Date")]
        public DateFormat SuspendEnd { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }

        [ForeignKey("Account")]
        public int AccountId { get; set; }
        public Account Account { get; set; }

        [ForeignKey("IdentityUser")]
        public string IndentityUserId { get; set; }
        public IdentityUser Identity { get; set; }






    }
}
