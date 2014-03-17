using System;
using TechTalk.SpecFlow;

namespace Endjin.Web.MetaWeblog.Integration.Specs.Steps
{
    [Binding]
    public class NewMediaObjectSteps
    {
        [Given(@"I want to be able to add a new image to the blog, with the name ""(.*)"", the type ""(.*)"", and the base(.*) content ""(.*)""")]
public void GivenIWantToBeAbleToAddANewImageToTheBlogWithTheNameTheTypeAndTheBaseContent(string p0, string p1, int p2, string p3)
{
    ScenarioContext.Current.Pending();
}
    }
}
