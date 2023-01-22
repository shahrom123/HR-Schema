using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructre.Services
{
    public class DeparmentService
    {
        private readonly DataContext _context;
        public DeparmentService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<DeparmentDto>> Get()
        {
            var employee = _context.Deparments.Select(x => new DeparmentDto
            {
                Id = x.Id,
                Name = x.Name,
                ManagerId= x.ManagerId,
                LocationId= x.LocationId,
            }).ToListAsync();
            return await employee;
        }

        public async Task<DeparmentDto> Add(DeparmentDto deparmentDto)
        {
            try
            {
                var d = new Deparment(deparmentDto.Id, deparmentDto.Name, deparmentDto.ManagerId, deparmentDto.LocationId);
                _context.Add(d);
                _context.Deparments.Add(d);
                _context.SaveChangesAsync();
                return deparmentDto;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw;
            } 
        }

        public async Task<DeparmentDto> Update(DeparmentDto deparmentDto)
        {
            try
            {
                var region = _context.Deparments.Find(deparmentDto.Id);
                if (region == null) return null;
                region.Id = deparmentDto.Id;
                region.Name = deparmentDto.Name;
                region.ManagerId = deparmentDto.ManagerId;
                var save = await  _context.SaveChangesAsync();
                if (save == 0) return null;
                return deparmentDto;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw;
            }
           
        }
        public bool Delete(int id)
        {
            var deparment = _context.Deparments.Find(id);
            if (deparment == null) return false;
            _context.Deparments.Remove(deparment);
            _context.SaveChangesAsync();
            return true;
        }
    }
}
