using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Order
  {
    public string Name { get; set; }
    public int Id { get; }
    public string Description { get; set; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string name, string description)
    {
      Description = description;
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;
    }
  }
}