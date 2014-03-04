namespace Endjin.Web.MetaWeblog.Mappers.XmlRpc.Response
{
    #region using directives

    using System.Collections.Generic;

    using Endjin.Web.MetaWeblog.Contracts.Mappers;
    using Endjin.Web.MetaWeblog.Domain.MetaWeblog.Response;
    using Endjin.Web.MetaWeblog.Domain.XmlRpc;

    #endregion

    public class PostIdToXmlRpcResponseMapper : IMapper<List<PostId>, Response>
    {
        public Response MapFrom(List<PostId> input)
        {
            var response = new Response();

            foreach (var PostId in input)
            {
                response.Params.Add(new ResponseParams
                {
                    Param = new ResponseParam
                    {
                        Value = new ResponseData
                        {
                            Data = new List<ResponseDataItem>
                            {
                                new ResponseDataItem
                                {
                                    Value = new ResponseParamValue
                                    {
                                        Member = new List<Member>
                                        {
                                            new Member
                                            {
                                                Name = "postid",
                                                Value = new MemberValue
                                                {
                                                    ValueChoice = MemberValue.ValueType.String,
                                                    Value = PostId.Id
                                                }
                                            },
                                        }
                                    }
                                }
                            }
                        }
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


