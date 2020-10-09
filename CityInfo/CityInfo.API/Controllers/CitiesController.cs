using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCities()
        {
            return Ok(CitiesDataStore.Current.Citites);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            CityDto city = CitiesDataStore.Current.Citites.FirstOrDefault(c => c.Id == id);
        
            if(city == null)
            {
                return NotFound();
            }

            return Ok(city);
        }
    }
}
