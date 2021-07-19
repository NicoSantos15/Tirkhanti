using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tirkhanti_R12.Models
{
    public class LeaderAssignedReport
    {
        [Display(Name = "Assigned Date")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime AssignedDate { get; set; }

        [Display(Name = "Date Completed")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CompleteDate { get; set; }
    }
}
