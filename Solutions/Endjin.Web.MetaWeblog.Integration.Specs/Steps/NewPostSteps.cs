using System;
using Endjin.Web.MetaWeblog.Domain.XmlRpc;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

using System.Linq;
using NUnit.Framework;


namespace Endjin.Web.MetaWeblog.Integration.Specs.Steps
{
    [Binding]
    public class NewPostSteps
    {

        [Given(@"I want to be able to add a new blog post to the site, with the following content:")]
        public void GivenIWantToBeAbleToAddANewBlogPostToTheSiteWithTheFollowingContent(Table table)
        {
            var xmlRpc = ScenarioContext.Current.Get<Request>(Keys.XmlRpcRequest);

            xmlRpc.Method = "metaWeblog.newPost";

            //Add post details to the XmlRpc Request
            var newPostDetails = table.CreateSet<String>().ToList();

            var title = newPostDetails[0];
            var description = newPostDetails[1];
            var categories = newPostDetails[3];

            var param = new RequestParam
                {
                    RequestValue =
                    {
                        ValueChoice = MemberValue.ValueType.String,
                        Value = ""
                    }
                };

            xmlRpc.Params.Add(param);

            ScenarioContext.Current.Set(xmlRpc, Keys.XmlRpcRequest);
        }

        [Given(@"it should be added as a draft")]
        public void GivenItShouldBeAddedAsADraft()
        {
            var xmlRpc = ScenarioContext.Current.Get<Request>(Keys.XmlRpcRequest);

            var param = new RequestParam
            {
                RequestValue =
                    {
                        ValueChoice = MemberValue.ValueType.String,
                        Value = "false"
                    }
            };
            xmlRpc.Params.Add(param);

            ScenarioContext.Current.Set(xmlRpc, Keys.XmlRpcRequest);
        }

        [Given(@"it should be published")]
        public void GivenItShouldBePublished()
        {
            var xmlRpc = ScenarioContext.Current.Get<Request>(Keys.XmlRpcRequest);

            var param = new RequestParam
            {
                RequestValue =
                {
                    ValueChoice = MemberValue.ValueType.String,
                    Value = "true"
                }
            };
            xmlRpc.Params.Add(param);

            ScenarioContext.Current.Set(xmlRpc, Keys.XmlRpcRequest);
        }


        [Then(@"the post should be added to the site as a draft")]
        public void ThenThePostShouldBeAddedToTheSiteAsADraft()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the post should be added to the site and published")]
        public void ThenThePostShouldBeAddedToTheSiteAndPublished()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
