


[TestFixture]
public class ManageListingTest : Commondriver
{
    ProfilePage profilepageObj = new ProfilePage();
    ManageListing managelistingObj = new ManageListing();

    [Test,Order(1)]
    public void ViewListing()
    {
        profilepageObj.ManageListing();
        Wait.TurnOnWait();
        managelistingObj.ViewRecord();
       
        
    }
    [Test,Order(2)]
    public void UpdateListing()
    {
         profilepageObj.ManageListing();
        Wait.TurnOnWait();
        managelistingObj.UpdateRecord();

    }
    [Test,Order(3)]
    public void DeleteListing()
    {
        profilepageObj.ManageListing();
        managelistingObj.DeleteRecord();
        
    }
}