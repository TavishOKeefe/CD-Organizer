using Microsoft.VisualStudio.TestTools.UnitTesting;
using Organizer.Models;
using System.Collections.Generic;
using System;

namespace Organizer.Tests
{
  [TestClass]
  public class CDTest
  {
    [TestMethod]
  public void CDConstructor_CreatesInstanceOfCD_CD()
  {
    CD newCD = new CD("Metallica");
    Assert.AreEqual(typeof(CD), newCD.GetType());
  }

    [TestMethod]
    public void GetTitle_ReturnsTitle_Title()
    {
      string name = "Metallica";
      CD newCD = new CD(name);

      string result = newCD.GetTitle();

      Assert.AreEqual(name, result);
    }







  }
}
