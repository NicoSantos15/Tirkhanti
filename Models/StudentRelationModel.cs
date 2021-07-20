using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tirkhanti_R12.Models
{
    public class StudentRelationModel
    {
        public IEnumerable<StudentReport> GetReport { get; set; }
        public IEnumerable<Emotions> GetEmotions { get; set; }
    }
}
