using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tirkhanti_R12.Models
{
    //public enum EmotionType 
    //{ 
    //    Happy,
    //    Okay,
    //    Annoyed,
    //    Frustrated,
    //    Angry,
    //    Help
    //}

    public class Emotions
    {
        [Key]
        [Display(Name = "Emotion ID")]
        [Required]
        public int EmotionID { get; set; }

        [Display(Name = "Student Emotion")]
        [Required]
        public string StudentEmotion { get; set; }

        //[ForeignKey("Id")]
        //[Display(Name = "Respond By")]
        //public Tirkhanti_R12Users RespondBy { get; set; }
    }
}
