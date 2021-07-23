using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Order
  {
    public string Title { get; set; }
    public int Id { get; }
    public string Description { get; set; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string title, string description)
    {
      Description = description;
      Title = title;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }
  }
}