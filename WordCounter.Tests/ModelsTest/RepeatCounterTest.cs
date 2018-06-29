using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {

        [TestMethod]
        public void checkSpecialCharacters_CheckIfTrue_True()
        {
            RepeatCounter repeat = new RepeatCounter();
            Assert.AreEqual(true, repeat.CheckSpecialCharacters("word is a good word"));
        }

        [TestMethod]
        public void removeSpecialCharacters_EnsureRemoved()
        {
            RepeatCounter repeat = new RepeatCounter();
            Assert.AreEqual("word123", repeat.RemoveSpecialCharacters("word!!!&&&123%%##@"));
        }

        [TestMethod]
        public void removeWhiteSpace_EnsureRemoved()
        {
            RepeatCounter repeat = new RepeatCounter();
            Assert.AreEqual("word123", repeat.RemoveWhiteSpace("word   123"));
        }
    }
}
