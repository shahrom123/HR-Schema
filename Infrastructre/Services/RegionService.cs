using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructre.Services
{
    public class RegionService
    {
        private readonly DataContext _context;
        public RegionService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<RegionDto>> GetRegions()
        {
            var region = _context.Regions.Select(x => new RegionDto
            {
                Id = x.Id,
                Name = x.Name,
            }).ToListAsync();

            return await region;
        }
        public async Task<RegionDto> AddRegion(RegionDto regionDto)
        {
            try
            {
                var region = new Region(regionDto.Id, regionDto.Name);
                _context.Regions.Add(region);
                var x = await _context.SaveChangesAsync();
                if (x == 0) return null;
                return regionDto; 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
     
        public async Task<bool> Update(RegionDto regionDto)
        {
            try
            {
                var updated = new Region()
                {
                    Id = regionDto.Id,
                    Name = regionDto.Name,
                };
                _context.Regions.Update(updated);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw;
            }
        
        }
     
        public async Task< bool> Delete(int id)
        {
            var region = _context.Regions.Find(id);
            if (region == null) return false;
            _context.Regions.Remove(region);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
