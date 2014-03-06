namespace Endjin.Web.MetaWeblog.WebApi.Controllers
{
    #region Using Directives

    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Formatting;
    using System.Threading.Tasks;
    using System.Web.Http;

    using Endjin.Web.MetaWeblog.Contracts.Mappers;
    using Endjin.Web.MetaWeblog.Contracts.Processors;
    using Endjin.Web.MetaWeblog.Domain.XmlRpc;
    using Endjin.Web.MetaWeblog.WebApi.Configuration;

    #endregion 

    [XmlRpcConfig]
    public class MetaWeblogController : ApiController
    {
        private readonly IRequestMapperFactory requestMapperFactory;
        private readonly IResponseMapperFactory responseMapperFactory;
        private readonly IProcessorFactory processorFactory;

        public MetaWeblogController(IRequestMapperFactory requestMapperFactory, IResponseMapperFactory responseMapperFactory, IProcessorFactory processorFactory)
        {
            this.requestMapperFactory = requestMapperFactory;
            this.responseMapperFactory = responseMapperFactory;
            this.processorFactory = processorFactory;
        }
        
        public async Task<HttpResponseMessage> PostAsync(Request request)
        {
            if (request == null)
            {
                return this.Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }

            var requestMapper = this.requestMapperFactory.GetContentFor(request.Method);
            var responseMapper = this.responseMapperFactory.GetContentFor(request.Method);
            var processor = this.processorFactory.GetContentFor(request.Method);

            var metaWeblogRequest = requestMapper.MapFrom(request);
            var result = await processor.ProcessAsync(metaWeblogRequest);
            dynamic response = responseMapper.MapFrom(result);

            var message = new HttpResponseMessage(HttpStatusCode.OK);

            switch (request.Method)
            {
                case "blogger.getUsersBlogs":
                    message.Content = new ObjectContent(typeof(Response), response, new XmlMediaTypeFormatter());
                    break;
            }

            return message;
        }
    }
}