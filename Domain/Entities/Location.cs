﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Location
    {
        public int Id { get; set; }
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public int CountryId { get; set; } 
        public Location() { }
        public Location(int id, string streetAddress, string postalCode, string city, string stateProvince, int countryId)
        {
            Id = id;
            StreetAddress = streetAddress;
            PostalCode = postalCode;
            City = city;
            StateProvince = stateProvince;
            CountryId = countryId;
        }
    }
}
