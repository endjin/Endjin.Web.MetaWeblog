namespace Endjin.Web.MetaWeblog.Mappers.XmlRpc.Request
{
    #region Using Directives

    using System.Linq;

    using Endjin.Web.MetaWeblog.Contracts.Mappers;
    using Endjin.Web.MetaWeblog.Domain.MetaWeblog.Request;
    using Endjin.Web.MetaWeblog.Domain.XmlRpc;

    #endregion

    public class XmlRpcRequestToGetRecentPostsRequestMapper : IMapper<Request, GetRecentPostsRequest>
    {
        public GetRecentPostsRequest MapFrom(Request input)
        {
            return new GetRecentPostsRequest
            {
                AppKey = input.Params.ElementAt(0).RequestValue.Value.ToString(),
                UserName = input.Params.ElementAt(1).RequestValue.Value.ToString(),
                Password = input.Params.ElementAt(2).RequestValue.Value.ToString(),
                NumberOfPosts = input.Params.ElementAt(3).RequestValue.Value.ToString(),
            };
        }

        public object MapFrom(object input)
        {
            return this.MapFrom((Request)input);
        }
    }
}