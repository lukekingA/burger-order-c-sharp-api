using System.Collections.Generic;
using burger_order.Interface;
using burger_order.Models;

namespace burger_order.Controllers {
  public class Invoice {
    public List<IItem> InvoiceItems { get; set; }
    public decimal Total { get; set; }

    public Invoice (Order order) {
      InvoiceItems = new List<IItem> ();

      Total = 0;
      foreach (IItem item in order.OrderItems) {
        Total += item.Price;
      }
    }
  }
}