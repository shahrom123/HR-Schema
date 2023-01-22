using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Deparment
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ManagerId { get; set; }

        public Location Locations { get; set; }
        public int LocationId { get; set; }
        public Deparment() { }
        public Deparment(int id, string name, int managerId, int locationId)
        {
            Id = id;
            Name = name;
            ManagerId = managerId;
            LocationId = locationId;
        }
    }
}
