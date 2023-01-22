using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructre.Services
{
    public class JobService
    {
        private readonly DataContext _context;
        public JobService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<JobDto>> Get()
        {
            var l = _context.Jobs.Select(x => new JobDto
            {
                Id = x.Id,
                Title = x.Title,
                MinSalary= x.MinSalary,
                MaxSalary= x.MaxSalary,
              
            }).ToList();

            return l;
        }
        public async Task <JobDto> Add(JobDto JobDto)
        {
            try
            {
                var location = new Job(JobDto.Id, JobDto.Title, JobDto.MinSalary, JobDto.MaxSalary);
                _context.Jobs.Add(location);
                var x = await _context.SaveChangesAsync();
                if (x == 0) return null;
                return JobDto; 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw;
            } 
        }

        public async Task<JobDto>Update(JobDto jobDto)
        {
            try
            {
                var region = _context.Jobs.Find(jobDto.Id);
                if (region == null) return null;
                region.Id = jobDto.Id;
                region.Title = jobDto.Title;
                region.MinSalary = jobDto.MinSalary;
                region.MaxSalary = jobDto.MaxSalary;
                var save = await _context.SaveChangesAsync();
                if (save == 0) return null;
                return jobDto; 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public bool Delete(int id)
        {
            var location = _context.Jobs.Find(id);
            if (location == null) return false;
            _context.Jobs.Remove(location);
            _context.SaveChangesAsync();
            return true;
        }
    }
}
