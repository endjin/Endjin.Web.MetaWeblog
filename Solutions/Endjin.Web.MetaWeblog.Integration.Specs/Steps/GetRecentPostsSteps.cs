namespace Endjin.Web.MetaWeblog.Integration.Specs
{
    #region using directives

    using System.Diagnostics;
    using System.IO;
    using System.Net.Http;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    using Endjin.Web.MetaWeblog.Contracts.Domain;
    using Endjin.Web.MetaWeblog.Domain.XmlRpc;
    using Endjin.Web.MetaWeblog.Domain.XmlRpc.Request;
    using Endjin.Web.MetaWeblog.Integration.Specs.Steps;

    using TechTalk.SpecFlow;

    using MemberValue = Endjin.Web.MetaWeblog.Domain.XmlRpc.Request.MemberValue;

    #endregion

    [Binding]
    public class GetRecentPostsSteps
    {
        [Given(@"I want to be able to provide users with details of the previous blog post")]
        public void GivenIWantToBeAbleToProvideUsersWithDetailsOfThePreviousBlogPost()
        {
            var xmlRpc = ScenarioContext.Current.Get<RequestTop>(Keys.XmlRpcRequest);

            xmlRpc.Method = "metaWeblog.getRecentPosts";

            var param = new RequestParam
            {
                RequestValue =
                {
                    ValueChoice = MemberValue.ValueType.String,
                    Value = "1"
                }
            };

            xmlRpc.Params.Add(param);

            ScenarioContext.Current.Set(xmlRpc, Keys.XmlRpcRequest);
        }

        [Then(@"the response should contain details of recent posts, in the format that I expect")]
        public void ThenTheResponseShouldContainDetailsOfRecentPostsInTheFormatThatIExpect()
        {
            var request = ScenarioContext.Current.Get<RequestTop>(Keys.XmlRpcRequest);
            var httpResponseMessage = ScenarioContext.Current.Get<HttpResponseMessage>(Keys.HttpResponseMessage);
            var response = httpResponseMessage.Content.ReadAsAsync<IResponse>().Result;

            // Using 'using' also disposes of the stream tvm
            using (MemoryStream stream = new MemoryStream())
            {
                var serializer = new XmlSerializer(typeof(IResponse));
                serializer.Serialize(XmlWriter.Create(stream), response);
                Debug.WriteLine(Encoding.UTF8.GetString(stream.ToArray()));
                stream.Flush();
            }
        }

    }
}
