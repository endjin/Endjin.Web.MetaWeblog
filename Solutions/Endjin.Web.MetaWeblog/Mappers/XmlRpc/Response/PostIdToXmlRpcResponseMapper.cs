namespace Endjin.Web.MetaWeblog.Mappers.XmlRpc.Response
{
    #region Using Directives

    using System.Collections.Generic;

    using Endjin.Web.MetaWeblog.Contracts.Mappers;
    using Endjin.Web.MetaWeblog.Domain.MetaWeblog.Response;
    using Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.ConfirmationResponse;

    #endregion

    public class PostIdToXmlRpcResponseMapper : IMapper<List<PostId>, Response>
    {
        public Response MapFrom(List<PostId> input)
        {
            var response = new Response();

            foreach (var postId in input)
            {
                response.Params.Add(new ResponseParams
                {
                    Param = new ResponseParam
                    {
                        Value = new MemberValue
                              {
                                  ValueChoice = MemberValue.ValueType.String,
                                  Value = postId.Id
                              },
                    }
                });
            }

            return response;
        }

        public object MapFrom(object input)
        {
            return this.MapFrom((List<PostId>)input);
        }
    }
}
