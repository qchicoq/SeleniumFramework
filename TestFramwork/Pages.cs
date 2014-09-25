using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestFramwork
{
    public static class Pages
    {
        public static Homepage Homepage
        {
            get { var homepage = new Homepage();
                PageFactory.InitElements(Browser.Driver, homepage );
                return homepage;
            }
        }
    }


    public class Homepage
    {


        static string Url = "http://pluralsight.com";
        private static string PageTitle = "Pluralsight - Hardcore Developer Training";
        
        [FindsBy(How = How.LinkText, Using = "Authors" )]
        private IWebElement authorLink;
        
        
        
        
        public void Goto()
        {
            Browser.Goto(Url);
        }




        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        public void SelectAuthor(string authorName)
        {
            authorLink.Click();
        }
    }




}
