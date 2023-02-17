

using CompetitionTask.Pages;
using CompetitionTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


[TestFixture]
public class ManageListingTest : Commondriver
{
    ProfilePage profilepageObj = new ProfilePage();
    ManageListing managelistingObj = new ManageListing();

    [Test]
    public void ViewListing()
    {
        profilepageObj.ManageListing(driver);
        Thread.Sleep(1000);
        managelistingObj.ViewRecord(driver);
       
        
    }
    [Test]
    public void UpdateListing()
    {
         profilepageObj.ManageListing(driver);
        Thread.Sleep(1000);
        managelistingObj.UpdateRecord(driver);

    }
    [Test]
    public void DeleteListing()
    {
        profilepageObj.ManageListing(driver);
        managelistingObj.DeleteRecord(driver);
        
    }
}