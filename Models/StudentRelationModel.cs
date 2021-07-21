using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tirkhanti_R12.Models
{
    //Model view
    [Keyless]
    public class StudentRelationModel
    {
        //This model view can be refactored as needed.
        public virtual StudentReport GetReport { get; set; }
        public virtual Emotions GetEmotions { get; set; }
    }
}
