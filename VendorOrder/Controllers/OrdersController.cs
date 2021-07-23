using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;
using System.Collections.Generic;

namespace VendorOrder.Controllers
{

  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendorId);
    }
    [HttpPost("/orders/delete")]
    public ActionResult DeleteAll()
    {
      Order.ClearAll();
      return View();
    }
    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, objects> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }
  }
}