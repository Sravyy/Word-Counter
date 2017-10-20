using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter;

namespace WordCounter.Tests
{

  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void CountRepeats_GiveCount_int()
    {
      //Arrange
      RepeatCounter count = new RepeatCounter("I am walking my cat to the cats at the cat place","cat");
      var output = 2;
      //Act
      int result = count.CountRepeats();
      //Assert
      Assert.AreEqual(output, result);
    }
    [TestMethod]
    public void CountRepeats_CountIsZero_int()
    {
      //Arrange
      RepeatCounter count = new RepeatCounter("This is a dog","cat");
      var output = 0;
      //Act
      int result = count.CountRepeats();
      //Assert
      Assert.AreEqual(output, result);
    }
    [TestMethod]
    public void CountRepeats_CheckingAbsoluteMatch_int()
    {
      //Arrange
      RepeatCounter count = new RepeatCounter("Cathedral isnt for cats","cat");
      var output = 0;
      //Act
      int result = count.CountRepeats();
      //Assert
      Assert.AreEqual(output, result);
    }
  }
}
