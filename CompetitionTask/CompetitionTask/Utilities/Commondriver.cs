




namespace CompetitionTask.Utilities
{
    public class Commondriver
    {
        public static IWebDriver driver;
        public static ExtentReports extent;
        public static ExtentTest test1;

        public static string reportPath = @"C:\CompetitionTask\CompetitionTask\CompetitionTask\CompetitionTask\ExtentReport\Test.html";
        public static string reportXmlPath = @"C:\CompetitionTask\CompetitionTask\CompetitionTask\CompetitionTask\ExtentReport\Report.xml";
        
        [OneTimeSetUp]
        public void Intialization()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            driver = new ChromeDriver();
            //extent report
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(reportPath);
            extent.AttachReporter(htmlReporter);
            SignIn singninObj = new SignIn();
           singninObj.SignInAction();
            
        }
        [OneTimeTearDown]
        public void CloseRun()
        {

         
            string img = SaveScreenShotClass.SaveScreenshot(driver, "Report");
           test1.Log(Status.Info, "Snapshot below: " + test1.AddScreenCaptureFromPath(img));

            // end test. (Reports)
           // extent.RemoveTest(test1);

            // calling Flush writes everything to the log file (Reports)
          //  extent.Flush();

            //Close the browser
            driver.Quit();
        }
    }
}
