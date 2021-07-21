using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tirkhanti_R12.Models
{
    public class StudentReport
    {
        [Key]
        [Display(Name = "Report ID")]
        [Column(Order = 0)]
        [Required]
        public int ReportID { get; set; }

        [Column(Order = 1)]
        [Display(Name = "Report Date")]
        [DisplayFormat(DataFormatString = "{0:DD/MM/YYYY}")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? ReportDate { get; set; }

        [Column(Order = 5)]
        [Display(Name = "Student Comment")]
        public string StudentComment { get; set; }

        [Column(Order = 3)]
        [Display(Name = "Assigned Date")]
        [DisplayFormat(DataFormatString = "{0:DD/MM/YYYY}")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? AssignedDate { get; set; }

        [Column(Order = 4)]
        [Display(Name = "Complete Date")]
        [DisplayFormat(DataFormatString = "{0:DD/MM/YYYY}")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CompleteDate { get; set; }

        [Column(Order = 2)]
        [Display(Name = "Assigned to")]
        [ForeignKey("FirstName")]
        public Tirkhanti_R12Users AssignedTo { get; set; } //Should be the fname or id or leader

        [Column(Order = 9)]
        [Display(Name = "Priority")]
        [ForeignKey("EmotionID")]
        public Emotions Priority { get; set; }

        [Column(Order = 7)]
        [Display(Name = "Completed")]
        public bool? IsComplete { get; set; } = false;

        [Column(Order = 8)]
        [Display(Name = "selected emotion")]
        public string SelectedEmotion { get; set; }

        public virtual ICollection <Tirkhanti_R12Users> GetTirkhanti_R12Users { get; set; }

    }
}
