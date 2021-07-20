using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tirkhanti_R12.Models;

namespace Tirkhanti_Project.Models
{
    public class AllViewModel
    {
        public IEnumerable<Tirkhanti_R12Users> R12Users { get; set; }
        public IEnumerable <Emotions> EmotionClass { get; set; }
        public IEnumerable <LeaderAssignedReport> LeaderAssignedReports { get; set; }
        public IEnumerable <AspNetRoles> AspNetRole { get; set; }
        public IEnumerable <ASPNetUserRoles> AspNetUserRoles { get; set; }
        public IEnumerable <LeaderChecked> LeadersChecked { get; set; }
        public IEnumerable <StudentReport> StudentReports { get; set; }


    }
}
