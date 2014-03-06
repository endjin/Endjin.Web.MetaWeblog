using System.Collections;
using System.Globalization;
using Endjin.Web.MetaWeblog.Domain.XmlRpc;

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
                Title = input.Params.ElementAt(4).RequestValue.Member.FirstOrDefault(member => member.Name.ToString() == "title").Value.Value.ToString(),
                Description = input.Params.ElementAt(4).RequestValue.Member.FirstOrDefault(member => member.Name.ToString() == "description").Value.Value.ToString(),
                Categories = ((MemberValueArray)input.Params.ElementAt(4).RequestValue.Member.FirstOrDefault(member => member.Name.ToString() == "categories").Value.Value).Value.Select(memberValue => memberValue.Value.ToString()).ToArray(),
                Publish = input.Params.ElementAt(5).RequestValue.Value.ToString()
            };
        }

        public object MapFrom(object input)
        {
            return this.MapFrom((Request)input);
        }
    }
}
                 