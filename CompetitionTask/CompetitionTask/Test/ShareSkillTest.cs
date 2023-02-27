
namespace CompetitionTask.Test
{
    [TestFixture]
    public class ShareSkillTest:Commondriver
    {

        ProfilePage profilepageObj = new ProfilePage();
        ShareSkill skillObj = new ShareSkill();
        ManageListing managelistingObj = new ManageListing();
        [Test,Order(1)]
        public void CreateSkillListing()
        {
            
            test=extent.CreateTest("CreateSkillListing").Info("Test Started");
            profilepageObj.ShareSkill(driver);
            Thread.Sleep(1000);
            skillObj.CreateSkill(driver);
            test.Log(Status.Pass, "Test Passed");
        }
        [Test,Order(2)]
        public void UpdateSkillListing()
        {
            profilepageObj.ManageListing(driver);
            Thread.Sleep(1000);
            managelistingObj.UpdateRecord(driver);
        }
        [Test,Order(3)]
        public void DeleteSkillListing()
        {
            profilepageObj.ManageListing(driver);
            managelistingObj.DeleteRecord(driver);
        }
    }
}
