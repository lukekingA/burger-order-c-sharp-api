using System.Collections.Generic;
using burger_order.Interface;
using burger_order.Models;

namespace burger_order.Data {
  public static class Data {
    public static List<IItem> Menu = new List<IItem> () {
      new Burger (101, "Plain Burger", 3.00m),
      new Burger (102, "Cheese Burger", 4.00m),
      new Burger (103, "Double Cheese Burger", 5.00m),

      new Side (201, "Fries", 1.00m, "Small"),
      new Side (202, "Fries", 1.50m, "Medium"),
      new Side (203, "Fries", 2.00m, "Large"),

      new Drink (301, "Pepsi", 1.00m, "Small"),
      new Drink (302, "Pepsi", 1.50m, "Medium"),
      new Drink (303, "Pepsi", 2.00m, "Large"),
    };
  }
}