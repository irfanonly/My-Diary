using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyDiary.Controllers;

namespace UnitTestProject
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index_ShouldReturn()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);

            Assert.AreEqual(result.ViewName,"Index");
        }
    }
}
