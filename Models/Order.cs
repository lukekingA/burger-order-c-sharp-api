using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using burger_order.Interface;

namespace burger_order.Models {
  public class Order {
    [Range (1, 25)]
    public int Id { get; set; }
    public List<IItem> OrderItems { get; set; } = new List<IItem> ();

  }
}