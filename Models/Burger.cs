using burger_order.Interface;

namespace burger_order.Models {
  public class Burger : Item, IItem {
    public Burger (int id, string name, decimal price) : base (id, name, price) { }
  }
}