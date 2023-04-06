using Microsoft.AspNetCore.Mvc;
using The.Big.Zuck.Domain.Catalog;


HttpGet("{id:int}")]



namespace The.Big.Zuck.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        
    public IActionResult Get(int id)
    {
        var item = new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m);
        item.Id = id;
        return Ok(item);

    }

    [HttpPost("{id:int}/ratings")]
    public IActionResult PostRating(int id, Rating rating)
    {
        var item = new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m);
        item.Id = id;
        item.AddRating(rating);
        return Ok(item);
    }
    public IActionResult Post(Item item)
    {
        return Created("/catalog/42", item);
    }

            return Ok(item);
        }
    }
    
}