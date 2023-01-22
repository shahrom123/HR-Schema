using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
namespace Infrastructre.Services
{
    public class LocationService
    {
        private readonly DataContext _context;
        public LocationService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<LocationDto>> Get()
        {
            var locations = _context.Locations.Select(x => new LocationDto
            {
                Id = x.Id,
                StreetAddress= x.StreetAddress,
                City = x.City,
                PostalCode = x.PostalCode,
                StateProvince= x.StateProvince,
                CountryId= x.CountryId,
            }).ToList();
            return locations; 
        }
        public async Task<LocationDto> Add(LocationDto locationDto)
        {
            try
            {
                var location = new Location(locationDto.Id, locationDto.StreetAddress, locationDto.City,
            locationDto.PostalCode, locationDto.StateProvince, locationDto.CountryId);
                _context.Add(location);
                _context.Locations.Add(location);
                var x = await _context.SaveChangesAsync();
                if (x == 0) return null;
                return locationDto; 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw;
            }
        }
       
        public async Task <LocationDto> Update(LocationDto locationDto)
        {
            try
            {
                var region = _context.Locations.Find(locationDto.Id);
                if (region == null) return null;
                region.StreetAddress = locationDto.StreetAddress;
                region.City = locationDto.City;
                region.PostalCode = locationDto.PostalCode;
                region.StateProvince = locationDto.StateProvince;
                region.CountryId = locationDto.CountryId;
                await _context.SaveChangesAsync();

                return locationDto;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw;
            }
           
        }
        public async  Task<bool> Delete(int id)
        {
            var location = _context.Locations.Find(id);
            if (location == null) return false;
            _context.Locations.Remove(location);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
