using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Country> countries { get; set; }
        public Region() { }
        public Region(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
