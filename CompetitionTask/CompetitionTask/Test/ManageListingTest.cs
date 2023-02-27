


[TestFixture]
public class ManageListingTest : Commondriver
{
    ProfilePage profilepageObj = new ProfilePage();
    ManageListing managelistingObj = new ManageListing();

    [Test,Order(1)]
    public void ViewListing()
    {
        profilepageObj.ManageListing(driver);
        Thread.Sleep(1000);
        managelistingObj.ViewRecord(driver);
       
        
    }
    [Test,Order(2)]
    public void UpdateListing()
    {
         profilepageObj.ManageListing(driver);
        Thread.Sleep(1000);
        managelistingObj.UpdateRecord(driver);

    }
    [Test,Order(3)]
    public void DeleteListing()
    {
        profilepageObj.ManageListing(driver);
        managelistingObj.DeleteRecord(driver);
        
    }
}