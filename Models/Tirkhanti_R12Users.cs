using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Tirkhanti_R12.Models
{
    // Add profile data for application users by adding properties to the Tirkhanti_R12Users class
    public class Tirkhanti_R12Users : IdentityUser
    {
        //Ask tommorrow
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //public override string Id { get; set; }

        //Database model of first name
        [PersonalData]
        [Column(TypeName = "nvarchar(100)", Order = 1)]
        [Display(Name = "First Name")]
        [Required]
        [MaxLength(100, ErrorMessage = "First name is too long")]
        public string FirstName { get; set; }

        //Database model of last name
        [PersonalData]
        [Column(TypeName = "nvarchar(100)", Order = 2)]
        [Display(Name = "Last Name")]
        [Required]
        [MaxLength(100, ErrorMessage = "Last name is too long")]
        public string LastName { get; set; }

        [PersonalData]
        [Column(Order = 3)]
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; } = true;

        [Display(Name = "Date Created")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? AccountCreated { get; set; }
    }
}
