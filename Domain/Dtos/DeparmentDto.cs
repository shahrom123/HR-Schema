using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class DeparmentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ManagerId { get; set; }
        public int LocationId { get; set; }
        public DeparmentDto() { }
        public DeparmentDto(int id, string name, int managerId, int locationId)
        {
            Id = id;
            Name = name;
            ManagerId = managerId;
            LocationId = locationId;
        }
    }
}
