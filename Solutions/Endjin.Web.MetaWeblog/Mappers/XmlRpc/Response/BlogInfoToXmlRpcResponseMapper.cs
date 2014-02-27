namespace Endjin.Web.MetaWeblog.Mappers.XmlRpc.Response
{
    #region Using Directives

    using System.Collections.Generic;

    using Endjin.Web.MetaWeblog.Contracts.Mappers;
    using Endjin.Web.MetaWeblog.Domain.MetaWeblog.Response;
    using Endjin.Web.MetaWeblog.Domain.XmlRpc;

    #endregion 

    public class BlogInfoToXmlRpcResponseMapper : IMapper<List<BlogInfo>, Response>
    {
        public Response MapFrom(List<BlogInfo> input)
        {
            var response = new Response();

            foreach (var blogInfo in input)
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
                                                Name = "url",
                                                Value = new MemberValue
                                                {
                                                    ValueChoice = MemberValue.ValueType.String,
                                                    Value = blogInfo.Url
                                                }
                                            },
                                            new Member
                                            {
                                                Name = "blogid",
                                                Value = new MemberValue
                                                {
                                                    ValueChoice = MemberValue.ValueType.String,
                                                    Value = blogInfo.BlogId
                                                }
                                            },
                                            new Member
                                            {
                                                Name = "blogName",
                                                Value = new MemberValue
                                                {
                                                    ValueChoice = MemberValue.ValueType.String,
                                                    Value = blogInfo.BlogName
                                                }
                                            }
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
            return this.MapFrom((List<BlogInfo>)input);
        }
    }
}