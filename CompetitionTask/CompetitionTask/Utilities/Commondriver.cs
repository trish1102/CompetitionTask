using CompetitionTask.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionTask.Utilities
{
    public class Commondriver
    {
        public static IWebDriver driver;
        [SetUp]
        public void Intialization()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            driver = new ChromeDriver();
           SignIn singninObj = new SignIn();
           singninObj.SignInAction(driver);
            
        }
        //[TearDown]
        public void CloseRun()
        {
            driver.Quit();
        }
    }
}
