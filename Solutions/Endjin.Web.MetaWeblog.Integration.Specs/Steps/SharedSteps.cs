namespace Endjin.Web.MetaWeblog.Integration.Specs.Steps
{
    #region using directives

    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Formatting;
    using System.Text;
    using System.Threading;
    using System.Web.UI.WebControls;
    using System.Xml;
    using System.Xml.Serialization;

    using Endjin.Web.MetaWeblog.Domain.XmlRpc;
    using Endjin.Web.MetaWeblog.Domain.XmlRpc.Request;

    using Should;

    using TechTalk.SpecFlow;

    #endregion

    [Binding]
    public class SharedSteps
    {
        [Given(@"I have a user with an AppKey of ""(.*)""")]
        public void GivenIHaveAUserWithAnAppKeyOf(string appKey)
        {
            RequestTop xmlRpc;

            if (!ScenarioContext.Current.TryGetValue<RequestTop>(Keys.XmlRpcRequest, out xmlRpc))
            {
                xmlRpc = new RequestTop
                {
                    Params = new List<RequestParam>()
                };
            }

            var param = new RequestParam
            {
                RequestValue =
                {
                    ValueChoice = MemberValue.ValueType.String,
                    Value = appKey
                }
            };

            xmlRpc.Params.Add(param);

            ScenarioContext.Current.Set(xmlRpc, Keys.XmlRpcRequest);
        }

        [Given(@"a password ""(.*)""")]
        public void GivenAPassword(string password)
        {
            //var xmlRpc = ScenarioContext.Current.Get<Request>(Keys.XmlRpcRequest) ?? new Request { Params = new List<RequestParam>() };

            RequestTop xmlRpc;

            if (!ScenarioContext.Current.TryGetValue<RequestTop>(Keys.XmlRpcRequest, out xmlRpc))
            {
                xmlRpc = new RequestTop
                {
                    Params = new List<RequestParam>()
                };
            }

            var param = new RequestParam
            {
                RequestValue =
                    {
                        ValueChoice = MemberValue.ValueType.String,
                        Value = password
                    }
            };

            xmlRpc.Params.Add(param);

            ScenarioContext.Current.Set(xmlRpc, Keys.XmlRpcRequest);
        }

        [Given(@"the username ""(.*)""")]
        public void GivenTheUserName(string username)
        {
            RequestTop xmlRpc;

            if (!ScenarioContext.Current.TryGetValue<RequestTop>(Keys.XmlRpcRequest, out xmlRpc))
            {
                xmlRpc = new RequestTop
                {
                    Params = new List<RequestParam>()
                };
            }

            var param = new RequestParam
            {
                RequestValue =
                {
                    ValueChoice = MemberValue.ValueType.String,
                    Value = username
                }
            };

            xmlRpc.Params.Add(param);

            ScenarioContext.Current.Set(xmlRpc, Keys.XmlRpcRequest);
        }

        [Given(@"the blogId is (.*)")]
        public void GivenTheBlogIdIs(int blogId)
        {
            RequestTop xmlRpc;

            if (!ScenarioContext.Current.TryGetValue<RequestTop>(Keys.XmlRpcRequest, out xmlRpc))
            {
                xmlRpc = new RequestTop
                {
                    Params = new List<RequestParam>()
                };
            }

            var param = new RequestParam
            {
                RequestValue =
                {
                    ValueChoice = MemberValue.ValueType.String,
                    Value = blogId.ToString(CultureInfo.InvariantCulture)
                }
            };

            xmlRpc.Params.Add(param);

            ScenarioContext.Current.Set(xmlRpc, Keys.XmlRpcRequest);
        }

        [When(@"I send the details to the MetaWeblog endpoint")]
        public void WhenISendTheDetailsToTheMetaWeblogEndpoint()
        {
            var xmlRpc = ScenarioContext.Current.Get<RequestTop>(Keys.XmlRpcRequest);

            var request = HttpRequestMethods.CreateRequest("http://endjin.com/metaweblog", "text/xml", HttpMethod.Post, xmlRpc, new XmlMediaTypeFormatter());

            //To let me check if the Request object has been constructed correctly - testing the test!
            var xmlRpcRequest = request.Content.ReadAsAsync<RequestTop>().Result;

            using (MemoryStream stream = new MemoryStream())
            {
                var serializer = new XmlSerializer(typeof(RequestTop));
                serializer.Serialize(XmlWriter.Create(stream), xmlRpcRequest);
                Debug.WriteLine(Encoding.UTF8.GetString(stream.ToArray()));
                stream.Flush();
            }

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
