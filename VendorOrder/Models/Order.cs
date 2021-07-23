using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Order
  {
    public string Name { get; set; }
    public int Id { get; }
    public string Description { get; set; }
    private static List<Order> _instances = new List<Order> { };
  }
}