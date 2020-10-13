﻿using CityInfo.API.Models;
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
                    Description = "The onew ith a big park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto() {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most valid urbanpark in US" },
                        new PointOfInterestDto() {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Manhattan." },
                    }
                },

                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never finished",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto() {
                            Id = 3,
                            Name = "Cathedral of Our Lady",
                            Description = "A gothic style cathedral" },
                        new PointOfInterestDto() {
                            Id = 4,
                            Name = "Antwerp central station",
                            Description = "The finest example of railway architecture in Belgium." }
                    }
                },

                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with that big tower",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto() {
                            Id = 5,
                            Name = "Eiffel Tower",
                            Description = "A wrough iron lattice tower on the Champ of Mars" },
                        new PointOfInterestDto() {
                            Id = 6,
                            Name = "The Louvre",
                            Description = "The world's largest museum" }
                    }
                }
            };
        }
    }
}
