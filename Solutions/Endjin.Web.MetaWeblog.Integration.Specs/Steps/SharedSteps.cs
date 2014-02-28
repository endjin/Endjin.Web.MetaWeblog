using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using Endjin.Web.MetaWeblog.Domain.XmlRpc;
using Should;
using TechTalk.SpecFlow;

namespace Endjin.Web.MetaWeblog.Integration.Specs.Steps
{
    [Binding]
    public class SharedSteps
    {
        [Given(@"I have a user with an AppKey of ""(.*)""")]
        public void GivenIHaveAUserWithAnAppKeyOf(string appKey)
        {
            var xmlRpc = new Request { Method = "blogger.getUsersBlogs", Params = new List<RequestParam>() };

            var param = new RequestParam { RequestValue = { String = appKey } };

            xmlRpc.Params.Add(param);

            ScenarioContext.Current.Set(xmlRpc, Keys.XmlRpcRequest);
        }

        [Given(@"a password ""(.*)""")]
        public void GivenAPassword(string password)
        {
            var xmlRpc = ScenarioContext.Current.Get<Request>(Keys.XmlRpcRequest);

            var param = new RequestParam { RequestValue = { String = password } };

            xmlRpc.Params.Add(param);

            ScenarioContext.Current.Set(xmlRpc, Keys.XmlRpcRequest);
        }

        [Given(@"the username ""(.*)""")]
        public void GivenTheUserName(string username)
        {
            var xmlRpc = ScenarioContext.Current.Get<Request>(Keys.XmlRpcRequest);

            var param = new RequestParam { RequestValue = { String = username } };

            xmlRpc.Params.Add(param);

            ScenarioContext.Current.Set(xmlRpc, Keys.XmlRpcRequest);
        }

        [When(@"I send the details to the MetaWeblog endpoint")]
        public void WhenISendTheDetailsToTheMetaWeblogEndpoint()
        {
            var xmlRpc = ScenarioContext.Current.Get<Request>(Keys.XmlRpcRequest);

            var request = HttpRequestMethods.CreateRequest("http://endjin.com/metaweblog", "text/xml", HttpMethod.Post, xmlRpc, new XmlMediaTypeFormatter());

            var client = ScenarioContext.Current.Get<HttpClient>(Keys.HttpClient);

            HttpResponseMessage response = client.SendAsync(request, new CancellationTokenSource().Token).Result;

            ScenarioContext.Current.Set(response, Keys.HttpResponseMessage);
        }

        [Then(@"I should receive a valid response")]
        public void ThenIShouldReceiveAValidResponse()
        {
            var response = ScenarioContext.Current.Get<HttpResponseMessage>(Keys.HttpResponseMessage);

            response.StatusCode.ShouldEqual(HttpStatusCode.OK);
            //Why isn't there an 'Assert' here? 
        }
    }
}
