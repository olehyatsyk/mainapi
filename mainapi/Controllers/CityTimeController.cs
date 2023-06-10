using mainapi.Clients;
using mainapi.models;
using Microsoft.AspNetCore.Mvc;

namespace mainapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityTimeController : ControllerBase
    {
        [HttpGet(Name = "CityTime")]
        public CityTime City(string CityName)
        {
            Client clients = new Client();
            return clients.GetTimeByCityAsync(CityName).Result;
        }
    }
}
