using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests.ControllerTests
{
    [TestClass]
    public class GameControllerTest
    {
        [TestMethod]
        public void Form_ReturnsCorrectView_True()
        {
            //Arrange
            GameController controller = new GameController();

            //Act
            ActionResult indexView = controller.Form();

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void Item_ReturnsCorrectView_True()
        {
            //Arrange
            GameController controller = new GameController();

            //Act
            ActionResult indexView = controller.Item(0);

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void Results_ReturnsCorrectView_True()
        {
            //Arrange
            GameController controller = new GameController();

            //Act
            ActionResult indexView = controller.Results();

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void Item_HasCorrectModelType_RepeatCounterList()
        {
            //Arrange
            GameController controller = new GameController();
            IActionResult actionResult = controller.Item(0);
            ViewResult indexView = controller.Item(0) as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(RepeatCounter));
        }
    }
}