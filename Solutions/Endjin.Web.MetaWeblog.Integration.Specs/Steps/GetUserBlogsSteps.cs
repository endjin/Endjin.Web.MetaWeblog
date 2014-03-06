namespace Endjin.Web.MetaWeblog.Integration.Specs.Steps
{
    #region Using Directives

    using Endjin.Web.MetaWeblog.Domain.XmlRpc;

    using TechTalk.SpecFlow;

    #endregion 

    [Binding]
    public class GetUserBlogsSteps
    {

        [Given(@"I want to validate that the current user has a valid account with the MetaWeblog service")]
        public void GivenIWantToValidateThatTheCurrentUserHasAValidAccountWithTheMetaWeblogService()
        {
            var xmlRpc = ScenarioContext.Current.Get<RequestTop>(Keys.XmlRpcRequest);

            xmlRpc.Method = "blogger.getUsersBlogs";

            ScenarioContext.Current.Set(xmlRpc, Keys.XmlRpcRequest);
        }
    }
}