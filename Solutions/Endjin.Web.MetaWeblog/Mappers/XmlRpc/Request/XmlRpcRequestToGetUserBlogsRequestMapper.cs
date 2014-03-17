namespace Endjin.Web.MetaWeblog.Mappers.XmlRpc.Request
{
    #region Using Directives

    using System.Linq;

    using Endjin.Web.MetaWeblog.Contracts.Mappers;
    using Endjin.Web.MetaWeblog.Domain.MetaWeblog.Request;
    using Endjin.Web.MetaWeblog.Domain.XmlRpc;

    #endregion 

    public class XmlRpcRequestToGetUserBlogsRequestMapper : IMapper<RequestTop, GetUserBlogsRequest>
    {
        public GetUserBlogsRequest MapFrom(RequestTop input)
        {
            return new GetUserBlogsRequest
            {
                AppKey = input.ValueAsString(0),
                Password = input.ValueAsString(2),
                UserName = input.ValueAsString(1)
            };
        }

        public object MapFrom(object input)
        {
            return this.MapFrom((RequestTop)input);
        }
    }
}
