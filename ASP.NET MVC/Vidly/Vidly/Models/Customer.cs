using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")] // in order to prevent property from being nullable type
        [StringLength(255)]
        public string Name { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        // Navigation property
        public MembershipType MembershipType { get; set; }

        // ForeignKey property
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; } 
    }
}