using System.ComponentModel.DataAnnotations;
using burger_order.Interface;

namespace burger_order.Models {
  abstract public class Item : IItem {
    [Required]
    public int Id { get; private set; }

    [Required]
    public string Name { get; private set; }

    [Required]
    public decimal Price { get; private set; }

    public Item (int id, string name, decimal price) {
      Name = name;
      Price = price;
      Id = id;
    }
  }
}