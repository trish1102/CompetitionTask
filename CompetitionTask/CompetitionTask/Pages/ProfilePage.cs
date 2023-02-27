



namespace CompetitionTask.Pages
{
    public class ProfilePage : Commondriver
    {
        public void ShareSkill(IWebDriver driver)
        {
            //click on Shareskill
            Wait.WaitForElementToBeClickable(driver,"XPath", "//a[text()='Share Skill']", 10);
            IWebElement shareskillButton = driver.FindElement(By.XPath("//a[text()='Share Skill']"));
            shareskillButton.Click();

        }
        public void ManageListing(IWebDriver driver)
        {
            Wait.WaitForElementToBeClickable(driver, "XPath", "//a[contains(text(),'Manage Listings')]", 10);
            IWebElement managelistingButton = driver.FindElement(By.XPath("//a[contains(text(),'Manage Listings')]"));
            managelistingButton.Click();
        }
    }
}
