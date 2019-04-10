using System.Collections.Generic;
using shoeStore.Models;

namespace shoeStore.Database
{
  public static class Data
  {
    public static List<Shoe> Inventory = new List<Shoe>()
    {
      new Shoe(1, "J", 1),
      new Shoe(2, "Sketchers", 1),
      new Shoe(3, "Nike's", 4)
    };
  }
}