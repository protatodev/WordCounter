using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
        string word = "";

        [TestMethod]
        public string GetWord()
        {
            return word;
        }

        [TestMethod]
        public void checkSpecialCharacters_CheckIfTrue_True()
        {
            RepeatCounter repeat = new RepeatCounter();
            Assert.AreEqual(true, repeat.checkSpecialCharacters("word"));
        }

        [TestMethod]
        public void removeSpecialCharacters()
        {
      
        }
    }
}
