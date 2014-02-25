namespace Endjin.Web.MetaWeblog.Mappers.XmlRpc.Request
{
    #region Using Directives

    using System.Linq;

    using Endjin.Web.MetaWeblog.Contracts.Mappers;
    using Endjin.Web.MetaWeblog.Domain.MetaWeblog.Request;
    using Endjin.Web.MetaWeblog.Domain.XmlRpc;

    #endregion

    public class XmlRpcRequestToGetCategoriesRequestMapper : IMapper<Request, GetCategoriesRequest>
    {
        public GetCategoriesRequest MapFrom(Request input)
        {
            return new GetCategoriesRequest
            {
                AppKey = input.Params.ElementAt(0).RequestValue.String,
                Password = input.Params.ElementAt(2).RequestValue.String,
                UserName = input.Params.ElementAt(1).RequestValue.String,
            };
        }

        public object MapFrom(object input)
        {
            return this.MapFrom((Request)input);
        }
    }
}