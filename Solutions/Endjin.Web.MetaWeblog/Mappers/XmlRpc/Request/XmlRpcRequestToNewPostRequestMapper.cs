namespace Endjin.Web.MetaWeblog.Mappers.XmlRpc.Request
{
    #region using directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Endjin.Web.MetaWeblog.Contracts.Mappers;
    using Endjin.Web.MetaWeblog.Domain.MetaWeblog.Request;
    using Endjin.Web.MetaWeblog.Domain.XmlRpc;

    #endregion
    public class XmlRpcRequestToNewPostRequestMapper : IMapper<Request, NewPostRequest> 
    {
        public NewPostRequest MapFrom(Request input)
        {
            return new NewPostRequest
            {
                BlogId = input.Params.ElementAt(3).RequestValue.Value.ToString(),
                AppKey = input.Params.ElementAt(0).RequestValue.Value.ToString(),
                UserName = input.Params.ElementAt(1).RequestValue.Value.ToString(),
                Password = input.Params.ElementAt(2).RequestValue.Value.ToString(),
                title = input.Params.ElementAt(4).RequestValue.Value.ToString(),
                //description = PCLWebUtility.WebUtility.HtmlEncode(input.Params.ElementAt(7).RequestValue.Value.ToString()).Replace("\"", "&quot;"),
                //link = "http://www.endjin.com/blogs/" + input.Params.ElementAt(8).RequestValue.Value.ToString(),
                //Need to loop through categories...
                //categories[] = input.Params.ElementAt(8).RequestValue.Value.ToString(),
                Publish = input.Params.ElementAt(5).RequestValue.Value.ToString()
            };
        }

        public object MapFrom(object input)
        {
            return this.MapFrom((Request)input);
        }
    }
}
