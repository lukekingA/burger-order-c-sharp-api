using burger_order.Interface;

namespace burger_order.Models {
  public class Drink : Item, IItem {
    public string Size { get; set; }
    public Drink (int id, string name, decimal price, string size) : base (id, name, price) {
      Size = size;
    }
  }
}