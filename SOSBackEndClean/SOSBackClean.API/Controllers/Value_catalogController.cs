using Microsoft.AspNetCore.Mvc;
using SOSBackClean.Application.Interfaces;
using SOSBackClean.Application.Services.CatalogServices;

namespace SOSBackClean.API.Controllers
{
    [ApiController]
    [Route("Api/Catalogs")]
    public class Value_catalogController : Controller
    {
        private readonly ICatalogService _catalogService;

        public Value_catalogController(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_catalogService.GetValuesCatalogos());
        }
    }
}
