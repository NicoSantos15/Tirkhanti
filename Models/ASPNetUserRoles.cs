using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tirkhanti_Project.Models
{
    public class ASPNetUserRoles
    {
        [Display(Name = "Roles Assigned")]
        public string RolesAssigned { get; set; }
    }
}
