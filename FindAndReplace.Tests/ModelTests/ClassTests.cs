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
      Assert.AreEqual("Hello friend", variable.changer("Hello world", "world", "friend"));
    }
  }
}