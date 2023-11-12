using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Mygolf.Domain.Catalog;
using Mygolf.Data;

namespace Mygolf.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        private readonly StoreContext _db;

        public CatalogController(StoreContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok(_db.Items);
            // var items = new List<Item>()
            // {
            //     new Item("Shirt", "Ohio State Shirt", "Nike", 39.99m),
            //     new Item("Shorts", "Ohio State shorts", "Nike", 49.99m)
            // };
            // return Ok(items);

        }

        [HttpGet("{id:int}")]
        public IActionResult GetItems(int id)
        {
            var item = _db.Items.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Post(Item item)
        {
            _db.Add(item);
            _db.SaveChanges();
            return Created($"/catalog/{item.Id}", item);
        }

        [HttpPost("{id:int}/ratings")]
        public IActionResult PostRating(int id, [FromBody] Rating rating)
        {
            var item = new Item("Shirt", "Ohio State Shirt.", "Nike", 39.99m);
            item.Id = id;
            item.AddRating(rating);

            return Ok(item);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, Item item)
        {
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

    }


}