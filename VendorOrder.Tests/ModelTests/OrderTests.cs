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
    public void GetParameters_ReturnDescriptionTitle_String()
    {
      string title = "pizza";
      string description = "mild spiced pepperoni pizza";
      
      Order newOrder = new Order(title, description);
      string resultTitle = newOrder.Title;
      string resultDescription = newOrder.Description;

      Assert.AreEqual((title, description), (resultTitle, resultDescription));
    }
    [TestMethod]
    public void SetParameter_SetDescriptionTitle_String()
    {
      string title = "pizza";
      string description = "mild spiced pepperoni pizza";
      Order newOrder = new Order(title, description);

      string updatedTitle = "coke";
      string updatedDescription = "sugarfree coke";
      newOrder.Title = updatedTitle;
      newOrder.Description = updatedDescription;
      string resultTitle = newOrder.Title;
      string resultDescription = newOrder.Description;

      Assert.AreEqual((updatedTitle, updatedDescription), (resultTitle, resultDescription));

    }
    [TestMethod]
    public void GetAll_ReturnEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };

      //List<Order> resultTitle = Order.GetAll();
      List<Order> resultDescription = Order.GetAll();

      CollectionAssert.AreEqual(newList, resultDescription);
    }
  }
}