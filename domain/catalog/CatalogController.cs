using Microsoft.AspNetCore.Mvc;
using The.Big.Zuck.Domain.Catalog;

namespace The.Big.Zuck.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello world!")
        }
    }
}