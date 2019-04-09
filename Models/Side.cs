using burger_order.Interface;

namespace burger_order.Models {
  public class Side : Item, IItem {
    public Side (int id, string name, decimal price, string size) : base (id, name, price) {
      Size = size;
    }

    public string Size { get; set; }

  }
}