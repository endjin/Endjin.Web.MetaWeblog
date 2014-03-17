namespace Endjin.Web.MetaWeblog.Mappers.XmlRpc.Request
{
    using Endjin.Web.MetaWeblog.Contracts.Mappers;
    using Endjin.Web.MetaWeblog.Domain.MetaWeblog.Request;
    using Endjin.Web.MetaWeblog.Domain.XmlRpc;

    internal class XmlRpcRequestToDeletePostRequestMapper : IMapper<RequestTop, DeletePostRequest>
    {
        public DeletePostRequest MapFrom(RequestTop input)
        {
            return new DeletePostRequest
            {
                AppKey = input.ValueAsString(0),
                PostId = input.ValueAsString(3),
                Username = input.ValueAsString(1),
                Password = input.ValueAsString(2),
            };
        }

        public object MapFrom(object input)
        {
            return this.MapFrom((RequestTop)input);
        }

    }
}