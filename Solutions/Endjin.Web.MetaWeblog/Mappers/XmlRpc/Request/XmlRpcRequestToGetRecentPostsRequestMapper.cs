namespace Endjin.Web.MetaWeblog.Mappers.XmlRpc.Request
{
    #region Using Directives

    using System.Linq;

    using Endjin.Web.MetaWeblog.Contracts.Mappers;
    using Endjin.Web.MetaWeblog.Domain.MetaWeblog.Request;
    using Endjin.Web.MetaWeblog.Domain.XmlRpc;

    #endregion

    public class XmlRpcRequestToGetRecentPostsRequestMapper : IMapper<RequestTop, GetRecentPostsRequest>
    {
        public GetRecentPostsRequest MapFrom(RequestTop input)
        {
            return new GetRecentPostsRequest
            {
                AppKey = input.ValueAsString(0),
                UserName = input.ValueAsString(1),
                Password = input.ValueAsString(2),
                NumberOfPosts = input.ValueAsString(3)
            };
        }

        public object MapFrom(object input)
        {
            return this.MapFrom((RequestTop)input);
        }
    }
}