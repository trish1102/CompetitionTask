
namespace CompetitionTask.Pages
{
    public class SignIn
    { 
        public void SignInAction(IWebDriver driver)
    
        {
           
            //open browser
            Thread.Sleep(1000);
            //goto Url("http://localhost:5000")
            driver.Navigate().GoToUrl("http://localhost:5000");
            driver.Manage().Window.Maximize();
            //click sign in button
            IWebElement signinButton = driver.FindElement(By.XPath("//a[text()='Sign In']"));
            signinButton.Click();
            Global.ExcelLib.PopulateInCollection(@"C:\CompetitionTask\CompetitionTask\CompetitionTask\CompetitionTask\ExcelData\ManageListing.xlsx", "SignIn");
            //Enter username and password
            IWebElement usernameTextbox = driver.FindElement(By.Name("email"));
            usernameTextbox.SendKeys(Global.ExcelLib.ReadData(2,"Email"));
            IWebElement passwordTextbox = driver.FindElement(By.Name("password"));
            passwordTextbox.SendKeys(Global.ExcelLib.ReadData(2, "Password"));
            // click on login button
            IWebElement loginButton = driver.FindElement(By.XPath("//button[text()='Login']"));
            loginButton.Click();
        }
    }
}
