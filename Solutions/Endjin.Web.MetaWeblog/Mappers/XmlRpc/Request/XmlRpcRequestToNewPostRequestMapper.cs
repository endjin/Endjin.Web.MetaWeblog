namespace Endjin.Web.MetaWeblog.Mappers.XmlRpc.Request
{
    #region Using Directives

    using System.Globalization;
    using System.Linq;

    using Endjin.Web.MetaWeblog.Contracts.Mappers;
    using Endjin.Web.MetaWeblog.Domain.MetaWeblog.Request;
    using Endjin.Web.MetaWeblog.Domain.XmlRpc;
    using Endjin.Web.MetaWeblog.Domain.XmlRpc.Request;

    #endregion

    public class XmlRpcRequestToNewPostRequestMapper : IMapper<RequestTop, NewPostRequest> 
    {
        public NewPostRequest MapFrom(RequestTop input)
        {
            return new NewPostRequest
            {
                BlogId = input.Params.ElementAt(2).RequestValue.Value.ToString(),
                //BlogId = input.ContentValueAsString(2),
                UserName = input.Params.ElementAt(0).RequestValue.Value.ToString(),
                Password = input.Params.ElementAt(1).RequestValue.Value.ToString(),
                Title = input.ContentValueAsString(3, "title"),
                Description = input.ContentValueAsString(3, "description"),
                Categories = input.ContentValueAsArray(3, "categories"),
                Publish = input.Params.ElementAt(4).RequestValue.Value.ToString(),
            };
        }
         
        public object MapFrom(object input)
        {
            return this.MapFrom((RequestTop)input);
        }
    }
}