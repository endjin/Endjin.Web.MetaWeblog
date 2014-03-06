namespace Endjin.Web.MetaWeblog.Integration.Specs.Steps
{
    #region using directives

    using TechTalk.SpecFlow;

    #endregion

    [Binding]
    public class BloggerDeletePostSteps
    {
        [Given(@"I want to be able to delete a blog post with the id ""(.*)""")]
        public void GivenIWantToBeAbleToDeleteABlogPostWithTheId(string postId)
        {
            /*var xmlRpc = ScenarioContext.Current.Get<RequestTop>(Keys.XmlRpcRequest);

            xmlRpc.Method = "Blogger.deleteBlog";

            var param = new RequestParam
            {
                RequestValue =
                {
                    ValueChoice = MemberValue.ValueType.String,
                    Value = postId.ToString(CultureInfo.InvariantCulture)
                }
            };

            ScenarioContext.Current.Set(xmlRpc, Keys.XmlRpcRequest);*/
        }
    }
}
