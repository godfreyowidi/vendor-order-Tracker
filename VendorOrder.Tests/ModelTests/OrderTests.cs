using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetParameters_ReturnDescription_String()
    {
      
      string description = "mild spiced pepperoni pizza";
      
      Order newOrder = new Order(description);
      string resultDescription = newOrder.Description;

      Assert.AreEqual(description, resultDescription);
    }
    [TestMethod]
    public void SetParameter_SetDescription_String()
    {
      string description = "mild spiced pepperoni pizza";
      Order newOrder = new Order(description);

      string updatedDescription = "sugarfree coke";
      newOrder.Description = updatedDescription;
      string resultDescription = newOrder.Description;

      Assert.AreEqual(updatedDescription, resultDescription);

    }
    [TestMethod]
    public void GetAll_ReturnEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };

      List<Order> resultTitle = Order.GetAll();
      List<Order> resultDescription = Order.GetAll();

      CollectionAssert.AreEqual(newList, resultDescription);
    }

    [TestMethod]
    public void GetAll_ReturnOrders_OrderList()
    {
      string description1 = "mild spiced pepperoni pizza";
      string description2 = "sugarfree coke";

      Order newOrder1 = new Order(description1);
      Order newOrder2 = new Order(description2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}