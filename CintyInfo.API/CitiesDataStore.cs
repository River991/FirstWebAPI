using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CintyInfo.API.Models;

namespace CintyInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id=1,
                    Name="London",
                    Description = "Capital city of the UK"
                },
                new CityDto()
                {
                    Id=2,
                    Name="New York City",
                    Description = "The Big Apple"
                },
                new CityDto()
                {
                    Id=3,
                    Name="Bruges",
                    Description = "Good Beer and Bikes"
                }
            };
        }
    }
}
