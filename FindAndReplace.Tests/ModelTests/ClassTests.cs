//test file
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Class.Models;

namespace Class.Models.Tests
{
  [TestClass]
  public class ReplacerTest
  {
    [TestMethod]
    public void changer_alterUserInput_True()
    {
      Replacer variable = new Replacer();
      Assert.AreEqual("Hello friend apple banana fries", variable.changer("Hello world apple banana fries", "world", "friend"));
    }
  }
}