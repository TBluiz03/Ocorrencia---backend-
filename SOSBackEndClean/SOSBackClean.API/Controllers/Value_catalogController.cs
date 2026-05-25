using Microsoft.AspNetCore.Mvc;
using SOSBackClean.Application.Interfaces;
using SOSBackClean.Application.Services.CatalogServices;

namespace SOSBackClean.API.Controllers
{
    [ApiController]
    [Route("Api/Catalogs")]
    public class Value_catalogController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(EntryPoint.Provider().GetRequiredService<ICatalogService>().GetValuesCatalogos());
        }
    }
}
