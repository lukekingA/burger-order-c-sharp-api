using burger_order.Models;
using Microsoft.AspNetCore.Mvc;

namespace burger_order.Controllers {
  [Route ("api/[controller]")]
  [ApiController]
  public class OrderController : ControllerBase {

    [HttpPost]
    public ActionResult<Invoice> NewOrder ([FromBody] Order order) {

      return new Invoice (order);
    }
  }
}