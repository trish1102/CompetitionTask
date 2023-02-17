using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionTask.Pages
{
    public class ManageListing
    {
        public void ViewRecord(IWebDriver driver)
        {
            IWebElement viewButton = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[last()]/td[8]/div/button[1]/i"));
            viewButton.Click();
            IWebElement title = driver.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span"));
            String value = "I am providing service to learn selenium basic in 30min";
            Assert.That(title.Text == value, "test failed");
        }
        public void UpdateRecord(IWebDriver driver)
        {
            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[last()]/td[8]/div/button[2]"));
            updateButton.Click();
            IWebElement tagTextbox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div"));
            Thread.Sleep(1000);
            tagTextbox.Click();
            Thread.Sleep(1000);
            IWebElement tagBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            tagBox.SendKeys("path");
            tagBox.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]")).Click();
            IWebElement updatedTag = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div"));
            Assert.That(updatedTag.Text.Contains("path"), "Test failed");

        }
        public void DeleteRecord(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[last()]/td[8]/div/button[3]"));
            deleteButton.Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[1]")).Click();

        }
    }
}
