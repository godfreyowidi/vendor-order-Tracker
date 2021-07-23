using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test1", "test2");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetParameters_ReturnDescriptionName_String()
    {
      string name = "pizza";
      string description = "mild spiced pepperoni pizza";
      
      Order newOrder = new Order(name, description);
      string resultName = newOrder.Name;
      string resultDescription = newOrder.Description;
    }
  }
}