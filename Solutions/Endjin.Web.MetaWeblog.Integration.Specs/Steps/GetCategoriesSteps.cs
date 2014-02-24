using System;
using Endjin.Web.MetaWeblog.Domain.XmlRpc;
using TechTalk.SpecFlow;

namespace Endjin.Web.MetaWeblog.Integration.Specs.Steps
{
    [Binding]
    public class GetCategoriesSteps
    {
        [Given(@"I want to be able to provide users with a list of blog categories")]
        public void GivenIWantToBeAbleToProvideUsersWithAListOfBlogCategories()
        {
            var xmlRpc = ScenarioContext.Current.Get<Request>(Keys.XmlRpcRequest);

            xmlRpc.Method = "metaWeblog.getCategories";

            ScenarioContext.Current.Set(xmlRpc, Keys.XmlRpcRequest);
        }
    }
}
