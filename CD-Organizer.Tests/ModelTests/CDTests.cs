using Microsoft.VisualStudio.TestTools.UnitTesting;
using Organizer.Models;
using System.Collections.Generic;
using System;

namespace Organizer.Tests
{
  [TestClass]
  public class CDTest : IDisposable
  {
    public void Dispose()
    {
      CD.ClearAll();
    }
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
      [TestMethod]
  public void GetId_ReturnsCDId_Int()
  {
    //Arrange
    string name = "Test Category";

    CD newCD = new CD(name);

    //Act
    int result = newCD.GetId();

    //Assert
    Assert.AreEqual(1, result);
}
      [TestMethod]
     public void GetAll_ReturnsAllCategoryObjects_CategoryList()
     {
       //Arrange
       string name01 = "Work";
       string name02 = "School";
       CD newCD1 = new CD(name01);
       CD newCD2 = new CD(name02);
       List<CD> newList = new List<CD> { newCD1, newCD2 };

       //Act
       List<CD> result = CD.GetAll();

       //Assert
       CollectionAssert.AreEqual(newList, result);
     }
     [TestMethod]
     public void Find_ReturnsTheID_int()
     {
       string name01 = "Metallica";
       string name02 = "Band";
       CD nameCategory1 = new CD(name01);
       CD nameCategory2 = new CD(name02);

       CD result = CD.Find(2);

       Assert.AreEqual(nameCategory2, result);
     }
     [TestMethod]
     public void GetArtist_ReturnsEmptyArtistList_ItemList()
     {
   //Arrange
      string name = "Artist Name";
      CD newCategory = new CD(name);
      List<Artist> newList = new List<Artist> { };

   //Act
      List<Artist> result = newCategory.GetArtist();

   //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void AddItem_AssociatesItemWithCategory_ArtistList()
    {
      //Arrange
      string description = "Walk the dog.";
      Artist newArtist = new Artist(description);
      List<Artist> newList = new List<Artist> { newArtist };

      string name = "Work";
      CD newCD = new CD(name);
      newCD.AddArtist(newArtist);

      //Act
      List<Artist> result = newCD.GetArtist();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }





  }
}
