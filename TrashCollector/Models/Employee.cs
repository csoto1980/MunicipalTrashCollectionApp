using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TrashCollector.Action_Filter;

namespace TrashCollector.Models
{
    [ServiceFilter(typeof(GlobalRouting))]
    [Authorize(Roles = "Customer")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name Required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name Required")]
        public string LastName { get; set; }

        [Display(Name = "Zip Code")]
        [Required(ErrorMessage = "Zip Code Required")]
        public string ZipCode { get; set; }

        [ForeignKey("IdentityUser")]
        public string IndentityUserId { get; set; }
        public IdentityUser Identity { get; set; }
    }
}
