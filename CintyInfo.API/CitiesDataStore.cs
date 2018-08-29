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
                    Description = "Capital city of the UK",
                    PointsOfInterests = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Id=1,
                            Name="Big Ben",
                            Description = "Clock at the Houses of Parliament"
                        },
                        new PointOfInterest()
                        {
                            Id = 2,
                            Name = "Buckingham Palace",
                            Description = "The Queen's London Palace"
                        }
                    }
                },
                new CityDto()
                {
                    Id=2,
                    Name="New York City",
                    Description = "The Big Apple",
                    PointsOfInterests = new List<PointOfInterest>()
                    {
                    new PointOfInterest()
                    {
                    Id=1,
                    Name="Empire State Building",
                    Description = "Once the tallest building in the world"
                },
                new PointOfInterest()
                {
                    Id = 2,
                    Name = "Statue of Liberty",
                    Description = "Statue in New York Harbour"
                }
            }
                },
                new CityDto()
                {
                    Id=3,
                    Name="Bruges",
                    Description = "Good Beer and Bikes",
                    PointsOfInterests = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Id=1,
                            Name="The Bellfry",
                            Description = "Old Clock tower"
                        },
                        new PointOfInterest()
                        {
                            Id = 2,
                            Name = "Beer Museum",
                            Description = "Museum Dedicated to Beer"
                        }
                    }

                }
            };
        }
    }
}
