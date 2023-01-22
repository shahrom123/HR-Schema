

namespace Domain.Entities
{
    public class Job
    {
        public int Id { get; set; }
        public List<Employee> Employees { get; set; }
        public List<JobHistory> JobHistory {get; set;} 
        public string Title { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set;}

        public Job() { }

        public Job(int id, string title, int minSalary, int maxSalary)
        {
            Id = id;
            Title = title;
            MinSalary = minSalary;
            MaxSalary = maxSalary;
        }
    }
}
