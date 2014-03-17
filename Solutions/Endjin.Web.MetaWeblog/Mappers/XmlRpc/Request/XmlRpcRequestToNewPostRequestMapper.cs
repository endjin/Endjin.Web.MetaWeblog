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
                BlogId = input.ValueAsString(2),
                UserName = input.ValueAsString(0),
                Password = input.ValueAsString(1),
                Title = input.ValueAsString(3, "title"),
                Description = input.ValueAsString(3, "description"),
                Categories = input.ValueAsArray(3, "categories"),
                Publish = input.ValueAsString(4)
            };
        }
         
        public object MapFrom(object input)
        {
            return this.MapFrom((RequestTop)input);
        }
    }
}