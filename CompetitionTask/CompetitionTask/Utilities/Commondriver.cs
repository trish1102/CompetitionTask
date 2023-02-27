using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using CompetitionTask.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CompetitionTask.Utilities.Global;

namespace CompetitionTask.Utilities
{
    public class Commondriver
    {
        public static IWebDriver driver;
        public static ExtentTest test;
        public static ExtentReports extent;
        public static string reportPath = @"C:\CompetitionTask\CompetitionTask\CompetitionTask\CompetitionTask\ExtentReport\Test.html";
        public static string reportXmlPath = @"C:\CompetitionTask\CompetitionTask\CompetitionTask\CompetitionTask\ExtentReport\Report.xml";
        [OneTimeSetUp]
        public void Intialization()
        {
            //extent report
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
           driver = new ChromeDriver();
            extent =new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(reportPath);
            extent.AttachReporter(htmlReporter);
            SignIn singninObj = new SignIn();
           singninObj.SignInAction(driver);
            
        }
        [OneTimeTearDown]
        public void CloseRun()
        {
            string img = SaveScreenShotClass.SaveScreenshot(driver, "Report");
            test.Log(Status.Info, "Snapshot below: " + test.AddScreenCaptureFromPath(img));

            // end test. (Reports)
            extent.RemoveTest(test);

            // calling Flush writes everything to the log file (Reports)
            extent.Flush();

            //Close the browser
            driver.Quit();
        }
    }
}
