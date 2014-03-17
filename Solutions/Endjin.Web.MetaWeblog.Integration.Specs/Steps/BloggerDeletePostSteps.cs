namespace Endjin.Web.MetaWeblog.Integration.Specs.Steps
{
    #region using directives

    using System.Globalization;
    using System.Security.Cryptography;

    using Endjin.Web.MetaWeblog.Domain.XmlRpc;
    using Endjin.Web.MetaWeblog.Domain.XmlRpc.Request;

    using TechTalk.SpecFlow;

    #endregion

    [Binding]
    public class BloggerDeletePostSteps
    {
        [Given(@"I want to be able to delete a blog post with the id ""(.*)""")]
        public void GivenIWantToBeAbleToDeleteABlogPostWithTheId(string postId)
        {
            var xmlRpc = ScenarioContext.Current.Get<RequestTop>(Keys.XmlRpcRequest);

            xmlRpc.Method = "blogger.deletePost";

            var param = new RequestParam
            {
                RequestValue =
                {
                    ValueChoice = MemberValue.ValueType.String,
                    Value = postId.ToString(CultureInfo.InvariantCulture)
                }
            };

            xmlRpc.Params.Add(param);

            // A boolean is specified by the Blogger API, this is ignored but included here for completeness.
            var param2 = new RequestParam
            {
                RequestValue =
                {
                    ValueChoice = MemberValue.ValueType.@Boolean,
                    Value = 0
                }
            };
            xmlRpc.Params.Add(param2);

            ScenarioContext.Current.Set(xmlRpc, Keys.XmlRpcRequest);
        }
    }
}
