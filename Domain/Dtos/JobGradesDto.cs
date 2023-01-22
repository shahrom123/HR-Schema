using System;

namespace Domain.Dtos
{
    public class JobGradesDto 
    {
         public int Id { get; set; } 
        public string GradeLevel { get; set; }
        public int LowestSal { get; set; }
        public int HighestSal { get; set; }

        public JobGradesDto() { }
        public JobGradesDto(int id , string gradeLevel, int lowestSal, int highestSal)
        {
            Id = id;
            GradeLevel = gradeLevel;
            LowestSal = lowestSal;
            HighestSal = highestSal;
        }
    }
}
