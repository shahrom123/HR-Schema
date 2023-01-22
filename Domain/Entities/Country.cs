using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public List<Region> Region { get; set; }
        public int RegionId { get; set; } 

        public Country(){}
        public Country(int id, string name, int regionId)
        {
            Id = id;
            Name = name;
            RegionId = regionId;
        }
    }
}
