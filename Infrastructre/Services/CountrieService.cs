using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructre.Services
{
    public class    CountryService
    {
        private readonly DataContext _context;
        public CountryService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<CountryDto>> Get()
        {
            var locations = _context.Countries.Select(x => new CountryDto
            {
                Id = x.Id,
                Name = x.Name ,
                RegionId= x.RegionId ,
              
            }).ToListAsync();
            return await locations;
        }
        public async  Task<CountryDto> Add(CountryDto countryDto)
        {
            try
            {
                var location = new Country(countryDto.Id, countryDto.Name, countryDto.RegionId);
                _context.Add(location);
                _context.Countries.Add(location);
                var x = _context.SaveChangesAsync();
                return countryDto;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw;
            }
        
        }

        public async Task<CountryDto> Update(CountryDto countryDto)
        {
            try
            {
                var region = _context.Countries.Find(countryDto.Id);
                if (region == null) return null;
                region.Id = countryDto.Id;
                region.Name = countryDto.Name;
                region.RegionId = countryDto.RegionId;
                var save = _context.SaveChangesAsync();
                return  countryDto; 

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);   
                throw;
            }   
        }
        public async Task< bool> Delete(int id)
        {
            var location = _context.Countries.Find(id);
            if (location == null) return false;
            _context.Countries.Remove(location);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
