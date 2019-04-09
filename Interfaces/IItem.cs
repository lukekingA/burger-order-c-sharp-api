namespace burger_order.Interface {
  public interface IItem {
    int Id { get; }
    string Name { get; }
    decimal Price { get; }
  }
}