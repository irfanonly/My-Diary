using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyDiary.Controllers;
using MyDiary.Models;

namespace UnitTestProject
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index_ShouldReturn()
        {
            //Arrange
            var controller = new HomeController();
            //Act
            var result = controller.Index() as ViewResult;
            //Assert
            Assert.IsNotNull(result);

            Assert.AreEqual(result.ViewName,"Index");
        }
        [TestMethod]
        public void About_ShouldReturn()
        {
            //Arrange
            var controller = new HomeController();
            //Act
            var result = controller.About() as ViewResult;
            //Assert
            Assert.IsNotNull(result);

            Assert.AreEqual(result.ViewData["Message"], "Your application description page.");
        }

        [TestMethod]
        public void Contact_ShouldReturn()
        {
            //Arrange
            var controller = new HomeController();
            //Act
            var result = controller.Contact() as ViewResult;
            //Assert
            Assert.IsNotNull(result);

            Assert.AreEqual(result.ViewData["Message"], "Your contact page.");
        }

        
    }
}
