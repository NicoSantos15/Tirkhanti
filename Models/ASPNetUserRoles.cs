using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Tirkhanti_R12.Models;

namespace Tirkhanti_Project.Models
{
    public class ASPNetUserRoles
    {
        [Display(Name = "RoleID")]
        [ForeignKey("Id")]
        [Column(Order = 0)]
        public ASPNetUserRoles RoleID { get; set; }

        [Display(Name = "RoleID")]
        [ForeignKey("Id")]
        [Column(Order = 1)]
        public Tirkhanti_R12Users UserID { get; set; }
    }


}
