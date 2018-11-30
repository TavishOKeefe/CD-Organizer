using Microsoft.VisualStudio.TestTools.UnitTesting;
using Organizer.Models;
using System.Collections.Generic;
using System;

namespace Organizer.Tests
{
  [TestClass]
  public class ArtistTest : IDisposable
  {

    public void Dispose()
    {
      Artist.ClearAll();
    }

    [TestMethod]
    public void ArtistConstructor_CreatesInstanceOfArtist_Artist()
    {
      Artist newArtist = new Artist("test");
      Assert.AreEqual(typeof(Artist), newArtist.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      Artist newArtist = new Artist(description);

      //Act
      string result = newArtist.GetDescription();

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      Artist newArtist = new Artist(description);

      //Act
      string updatedDescription = "Do the dishes";
      newArtist.SetDescription(updatedDescription);
      string result = newArtist.GetDescription();

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ArtistList()
    {
      //Arrange
      List<Artist> newList = new List<Artist> { };

      //Act
      List<Artist> result = Artist.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsArtists_ArtistList()
    {
      //Arrange
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Artist newArtist1 = new Artist(description01);
      Artist newArtist2 = new Artist(description02);
      List<Artist> newList = new List<Artist> { newArtist1, newArtist2 };

      //Act
      List<Artist> result = Artist.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
       public void GetId_ArtistsInstantiateWithAnIdAndGetterReturns_Int()
       {
         //Arrange
         string description = "Walk the dog.";
         Artist newArtist = new Artist(description);

         //Act
         int result = newArtist.GetId();

         //Assert
         Assert.AreEqual(1, result);
       }
       [TestMethod]
       public void Find_ReturnsCorrectArtist_Artist()
       {
         //Arrange
         string description01 = "Walk the dog";
         string description02 = "Wash the dishes";
         Artist newArtist1 = new Artist(description01);
         Artist newArtist2 = new Artist(description02);

         //Act
         Artist result = Artist.Find(2);

         //Assert
         Assert.AreEqual(newArtist2, result);
       }


  }
}
