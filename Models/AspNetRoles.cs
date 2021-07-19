using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tirkhanti_R12.Models
{
    public enum RoleType
    {
        Student,
        Leader,
        SeniorLeader
    }
    public class AspNetRoles
    {
        [Key]
        [Required]
        [Display(Name = "Role ID")]
        public int RoleID { get; set; }

        [Display(Name = "Role Name")]
        [ForeignKey("RoleType")]
        public RoleType RoleName { get; set; }

    }
}
