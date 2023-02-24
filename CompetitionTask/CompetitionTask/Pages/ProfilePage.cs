



namespace CompetitionTask.Pages
{
    public class ProfilePage : Commondriver
    {
        public void ShareSkill(IWebDriver driver)
        {
            //click on Shareskill
            Thread.Sleep(1000);
            IWebElement shareskillButton = driver.FindElement(By.XPath("//a[text()='Share Skill']"));
            shareskillButton.Click();

        }
        public void ManageListing(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement managelistingButton = driver.FindElement(By.XPath("//a[contains(text(),'Manage Listings')]"));
            managelistingButton.Click();
        }
    }
}
