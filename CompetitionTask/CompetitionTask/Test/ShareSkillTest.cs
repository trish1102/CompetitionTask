
using AventStack.ExtentReports.Reporter;

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
           
            profilepageObj.ShareSkill();
            Wait.TurnOnWait();
            skillObj.CreateSkill();
           
        }
        [Test,Order(2)]
        public void UpdateSkillListing()
        {
            profilepageObj.ManageListing();
            Wait.TurnOnWait();
            managelistingObj.UpdateRecord();
        }
        [Test,Order(3)]
        public void DeleteSkillListing()
        {
            profilepageObj.ManageListing();
            managelistingObj.DeleteRecord();
        }
    }
}
