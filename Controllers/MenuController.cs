using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using burger_order.Data;
using burger_order.Interface;
using burger_order.Models;
using Microsoft.AspNetCore.Mvc;

namespace burger_order.Controllers {
  [Route ("api/[controller]")]
  [ApiController]

  public class MenuController : ControllerBase {

    List<IItem> Menu = Data.Data.Menu;

    [HttpGet]
    public ActionResult<List<IItem>> Get () {
      return Menu;
    }

    [HttpGet ("{id}")]
    public ActionResult<IItem> GetByName (int id) {
      IItem item = Menu.Find (i => i.Id == id);
      if (item != null) { return (Item) item; }
      return BadRequest ("Menu Item Not Found");
    }

    [HttpPost ("burger")]
    public ActionResult<List<IItem>> PostBurger ([FromBody] Burger item) {
      Menu.Add (item);
      return Menu;
    }

    [HttpPost ("side")]
    public ActionResult<List<IItem>> PostSide ([FromBody] Side item) {
      Menu.Add (item);
      return Menu;
    }

    [HttpPost ("drink")]
    public ActionResult<List<IItem>> PostDrink ([FromBody] Drink item) {
      Menu.Add (item);
      return Menu;
    }

    [HttpPut ("{id}")]
    public ActionResult<IItem> Put (int id, [FromBody] Item item) {
      IItem oldItem = Menu.Find (i => i.Id == id);
      if (oldItem == null) { return BadRequest ("No Menu Item Found with that name."); }
      int index = Menu.IndexOf (oldItem);
      Menu.Insert (index, item);
      return item;
    }

    [HttpDelete ("{id}")]
    public ActionResult Delete (int id) {
      IItem item = Menu.Find (i => i.Id == id);
      if (item == null) { return BadRequest ("Cannot delete item. Item not found"); }
      Menu.Remove (item);
      return Ok ("Item Deleted");
    }

  }
}