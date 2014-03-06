namespace Endjin.Web.MetaWeblog.WebApi.Controllers
{
    #region Using Directives

    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Web.Http;

    using Endjin.Web.MetaWeblog.Contracts.Mappers;
    using Endjin.Web.MetaWeblog.Contracts.Processors;
    using Endjin.Web.MetaWeblog.Domain.XmlRpc;
    using Endjin.Web.MetaWeblog.WebApi.Configuration;
    using Endjin.Web.MetaWeblog.WebApi.Contracts.Mappers;

    #endregion 

    [XmlRpcConfig]
    public class MetaWeblogController : ApiController
    {
        private readonly IRequestMapperFactory requestMapperFactory;
        private readonly IResponseMapperFactory responseMapperFactory;
        private readonly IHttpResponseMessageMapperFactory httpResponseMessageMapperFactory;
        private readonly IProcessorFactory processorFactory;

        public MetaWeblogController(
            IRequestMapperFactory requestMapperFactory, 
            IResponseMapperFactory responseMapperFactory, 
            IHttpResponseMessageMapperFactory httpResponseMessageMapperFactory, 
            IProcessorFactory processorFactory)
        {
            this.requestMapperFactory = requestMapperFactory;
            this.responseMapperFactory = responseMapperFactory;
            this.httpResponseMessageMapperFactory = httpResponseMessageMapperFactory;
            this.processorFactory = processorFactory;
        }
        
        public async Task<HttpResponseMessage> PostAsync(RequestTop request)
        {
            if (request == null)
            {
                return this.Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }

            var requestMapper = this.requestMapperFactory.GetContentFor(request.Method);
            var responseMapper = this.responseMapperFactory.GetContentFor(request.Method);
            var httpResponseMapper = this.httpResponseMessageMapperFactory.GetContentFor(request.Method);
            var processor = this.processorFactory.GetContentFor(request.Method);

            var metaWeblogRequest = requestMapper.MapFrom(request);
            var result = await processor.ProcessAsync(metaWeblogRequest);
            var response = responseMapper.MapFrom(result);

            return (HttpResponseMessage)httpResponseMapper.MapFrom(response);
        }
    }
}