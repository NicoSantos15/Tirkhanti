using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tirkhanti_R12.Models
{
    public class AspNetRoles : IdentityRole
    {
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
    }
}
