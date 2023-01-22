using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Domain.Entities
{
    public class JobGrades
    {
        [Key]
        public string GradeLevel { get; set; }
        public int LowestSal { get; set; }
        public int HighestSal { get; set; }
        public JobGrades() { }
        public JobGrades(string gradeLevel, int lowestSal, int highestSal)
        {
            GradeLevel = gradeLevel;
            LowestSal = lowestSal;
            HighestSal = highestSal;
        }
    }
}
