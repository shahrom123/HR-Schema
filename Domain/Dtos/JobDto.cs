using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class JobDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }

        public JobDto() { }

        public JobDto(int id, string title, int minSalary, int maxSalary)
        {
            Id = id;
            Title = title;
            MinSalary = minSalary;
            MaxSalary = maxSalary;
        }
    }
}
