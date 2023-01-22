using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegionId { get; set; }

        public CountryDto()
        {

        }
        public CountryDto(int id, string name, int regionId)
        {
            Id = id;
            Name = name;
            RegionId = regionId;
        }
    }
}
