using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tirkhanti_R12.Models
{
    [Keyless]
    public class LeaderChecked
    {
        [Display(Name = "Check by")]
        [ForeignKey("Id")]
        public Tirkhanti_R12Users CheckedBy { get; set; }

        [Display(Name = "Report checked")]
        [ForeignKey("ReportID")]
        public StudentReport ReportChecked { get; set; }

        [Display(Name = "Is Checked")]
        public bool IsChecked { get; set; }

        [Display(Name = "Checked Date")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? CheckedDate { get; set; }

    }
}
