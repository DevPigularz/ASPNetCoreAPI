using CityInfo.API.Models;
using System.Collections.Generic;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Citites { get; set; }

        public CitiesDataStore()
        {
            Citites = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The onew ith a big park"
                },

                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never finished"
                },

                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with that big tower"
                }
            };
        }
    }
}
