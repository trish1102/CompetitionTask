

namespace CompetitionTask.Test
{
    [TestFixture]
    public class ShareSkillTest:Commondriver
    {

        ProfilePage profilepageObj = new ProfilePage();
        ShareSkill skillObj = new ShareSkill();
        [Test]
        public void CreateListing()
        {
            profilepageObj.ShareSkill(driver);
            Thread.Sleep(1000);
            skillObj.CreateSkill(driver);
        }
    }
}
