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
                UserName = input.Params.ElementAt(0).RequestValue.Value.ToString(),
                Password = input.Params.ElementAt(1).RequestValue.Value.ToString(),
                Title = input.Params.ElementAt(3).RequestValue.Member.FirstOrDefault(member => member.Name.ToString() == "title").Value.Value.ToString(),
                Description = input.Params.ElementAt(3).RequestValue.Member.FirstOrDefault(member => member.Name.ToString() == "description").Value.Value.ToString(),
                //Categories = ((MemberValueArray)input.Params.ElementAt(4).RequestValue.Member.FirstOrDefault(member => member.Name.ToString(CultureInfo.InvariantCulture) == "categories").Value.Value).Value.Select(memberValue => memberValue.Value.ToString()).ToArray(),
                Publish = input.Params.ElementAt(4).RequestValue.Value.ToString()
            };
        }

        public object MapFrom(object input)
        {
            return this.MapFrom((RequestTop)input);
        }
    }
}