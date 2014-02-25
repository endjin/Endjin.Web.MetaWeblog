using System;
using System.Globalization;
using Endjin.Web.MetaWeblog.Domain.XmlRpc;
using Endjin.Web.MetaWeblog.Integration.Specs.Steps;
using TechTalk.SpecFlow;

namespace Endjin.Web.MetaWeblog.Integration.Specs
{
    [Binding]
    public class GetRecentPostsSteps
    {
        //[Given(@"I want to be able to provide users with details of recent blog posts")]
        //public void GivenIWantToBeAbleToProvideUsersWithDetailsOfRecentBlogPosts()
        //{
        //    var xmlRpc = ScenarioContext.Current.Get<Request>(Keys.XmlRpcRequest);

        //    xmlRpc.Method = "metaWeblog.getRecentPosts";

        //    ScenarioContext.Current.Set(xmlRpc, Keys.XmlRpcRequest);
        //}

        [Given(@"I want to be able to provide users with details of the previous blog post")]
        public void GivenIWantToBeAbleToProvideUsersWithDetailsOfThePreviousBlogPost()
        {
            var xmlRpc = ScenarioContext.Current.Get<Request>(Keys.XmlRpcRequest);

            xmlRpc.Method = "metaWeblog.getRecentPosts";

            var param = new RequestParam { RequestValue = { String = "1" } };

            xmlRpc.Params.Add(param);

            ScenarioContext.Current.Set(xmlRpc, Keys.XmlRpcRequest);
        }


    }
}
