using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tirkhanti_R12.Models
{
    public class LeaderChecked
    { 
        [Display(Name = "Is Checked")]
        public bool IsChecked { get; set; }

        [Display(Name = "Checked Date")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CheckedDate { get; set; }

        [Display(Name = "Check by")]
        [ForeignKey("FirstName")]
        public string CheckedBy { get; set; }

    }
}
