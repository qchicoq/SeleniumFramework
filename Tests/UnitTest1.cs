using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramwork;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Go_to_Homepage()
        {

            Pages.Homepage.Goto();
            Assert.IsTrue(Pages.Homepage.IsAt());

        }


        [TestMethod]

        public void Can_go_to_Author_page()
        {
           Pages.Homepage.Goto();
           Pages.Homepage.SelectAuthor("Matt Milner");
           Assert.IsTrue(Pages.Homepage.IsAtAutorPage());
        }

        [TestCleanup]
        public void CleanUp()
        {
            Browser.Close();

        }
    }
}
