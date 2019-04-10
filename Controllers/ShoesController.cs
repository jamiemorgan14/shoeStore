using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shoeStore.Database;
using shoeStore.Models;

namespace shoeStore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ShoesController : ControllerBase
  {
    List<Shoe> Inventory = Data.Inventory;
    // GET api/values
    [HttpGet]
    public ActionResult<List<Shoe>> Get()
    {
      return Inventory;
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<Shoe> GetById(int id)
    {
      Shoe found = Inventory.Find(s => s.Id == id);
      if (found == null)
      {
        return NotFound("Can't find shoe with that id");
      }
      return found;
    }

    // POST api/values
    [HttpPost]
    public ActionResult<List<Shoe>> Post([FromBody] Shoe value)
    {
      Inventory.Add(value);
      return Inventory;
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public ActionResult<Shoe> Put(int id, [FromBody] Shoe value)
    {
      Shoe oldShoe = Inventory.Find(s => s.Id == id);
      if (oldShoe == null)
      {
        return BadRequest("Can't find shoe with that id");
      }
      Inventory.Remove(oldShoe);
      Inventory.Add(value);
      return value;
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public ActionResult<Shoe> Delete(int id)
    {
      Shoe oldShoe = Inventory.Find(s => s.Id == id);
      if (oldShoe == null)
      {
        return BadRequest("Can't find shoe with that id");
      }
      Inventory.Remove(oldShoe);
      return Ok();
    }
  }
}
