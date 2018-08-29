using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CintyInfo.API.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfPointsOfInterest => PointsOfInterests.Count;
        public ICollection<PointOfInterest>  PointsOfInterests { get; set; } = new List<PointOfInterest>();
    }
}
