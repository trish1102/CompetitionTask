
namespace CompetitionTask.Pages
{
    public class ShareSkill:Commondriver
    {
        public void CreateSkill(IWebDriver driver)
        {
            Global.ExcelLib.PopulateInCollection(@"C:\CompetitionTask\CompetitionTask\CompetitionTask\CompetitionTask\ExcelData\ManageListing.xlsx", "ShareSkill");
            //get title textbox and send value
            IWebElement titleTextbox = driver.FindElement(By.Name("title"));
            titleTextbox.SendKeys(Global.ExcelLib.ReadData(2, "Title"));
            //get description textbox and send value
            IWebElement descriptionTextbox = driver.FindElement(By.Name("description"));
            descriptionTextbox.SendKeys(Global.ExcelLib.ReadData(2, "Description"));
            //get categery dropbox and select categery
            IWebElement categeryDropbox = driver.FindElement(By.XPath("//option[ text()='Programming & Tech']"));
            categeryDropbox.Click();
            // Thread.Sleep(1000);
            Wait.WaitForElementToBeClickable(driver,"XPath", "//option[ text()='QA']", 10);
            //get subcategery dropbox and select value
              IWebElement subcategeryDropbox = driver.FindElement(By.XPath("//option[ text()='QA']"));
             subcategeryDropbox.Click();
            //get tags texbox and send values
            IWebElement tagTextbox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div"));
            tagTextbox.Click();
            Wait.WaitForElementTobeExist(driver,"XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input", 10);
            IWebElement selecttagbox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            selecttagbox.SendKeys(Global.ExcelLib.ReadData(2, "Tags") + Keys.Enter);
            
             //select service type
            IWebElement servicetypeButton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
            servicetypeButton.Click();
            //select location type
            IWebElement locationtypeButton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
            locationtypeButton.Click();
            //select starting date
            IWebElement startDate = driver.FindElement(By.Name("startDate"));
            startDate.SendKeys(Global.ExcelLib.ReadData(2,"Start-Date"));
            //select end date
            IWebElement endDate = driver.FindElement(By.Name("endDate"));
            startDate.SendKeys(Global.ExcelLib.ReadData(2, "End-Date"));
            //select days and timing
            IWebElement dayCheckbox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input"));
            dayCheckbox.Click();
            IWebElement starttimeTextbox = driver.FindElement(By.Name("StartTime"));
            starttimeTextbox.SendKeys("10:30am");
            IWebElement finishtimeTextbox = driver.FindElement(By.Name("EndTime"));
            finishtimeTextbox.SendKeys("02:30am");
            //select skilltrade
            IWebElement skilltradeButton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
            skilltradeButton.Click();
            
            //select skill exchange
            IWebElement skillexchangeTextbox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div"));
            skillexchangeTextbox.Click();
            Wait.WaitForElementTobeExist(driver,"XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input", 10);
            IWebElement selectskillBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
            selectskillBox.SendKeys(Global.ExcelLib.ReadData(2, "Skill-Exchange") + Keys.Enter);
            //select active status
            IWebElement activestatusButton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));
            activestatusButton.Click();
            //get save button and click to save data
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
            saveButton.Click();
        }
       
        
    }
}
