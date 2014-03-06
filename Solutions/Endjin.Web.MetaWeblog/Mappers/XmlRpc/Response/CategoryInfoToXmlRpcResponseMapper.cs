namespace Endjin.Web.MetaWeblog.Mappers.XmlRpc.Response
{
    #region Using Directives

    using System.Collections.Generic;
    using System.Globalization;

    using Endjin.Web.MetaWeblog.Contracts.Mappers;
    using Endjin.Web.MetaWeblog.Domain.MetaWeblog.Response;
    using Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.MetaDataResponse;

    #endregion

    public class CategoryInfoToXmlRpcResponseMapper : IMapper<List<CategoryInfo>, Response>
    {
        public Response MapFrom(List<CategoryInfo> input)
        {
            var response = new Response();

            foreach (var categoryInfo in input)
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
                                                Name = "description",
                                                Value = new MemberValue
                                                {
                                                    ValueChoice = MemberValue.ValueType.String,
                                                    Value = categoryInfo.description
                                                }
                                            },
                                            new Member
                                            {
                                                Name = "categoryid",
                                                Value = new MemberValue
                                                {
                                                    ValueChoice = MemberValue.ValueType.String,
                                                    Value = categoryInfo.categoryid.ToString(CultureInfo.InvariantCulture)
                                                }
                                            },
                                            new Member
                                            {
                                                Name = "title",
                                                Value = new MemberValue
                                                {
                                                    ValueChoice = MemberValue.ValueType.String,
                                                    Value = categoryInfo.title
                                                }
                                            },
                                            new Member
                                            {
                                                Name = "htmlUrl",
                                                Value = new MemberValue
                                                {
                                                    ValueChoice = MemberValue.ValueType.String,
                                                    Value = categoryInfo.htmlUrl
                                                }
                                            },
                                            new Member
                                            {
                                                Name = "rssUrl",
                                                Value = new MemberValue
                                                {
                                                    ValueChoice = MemberValue.ValueType.String,
                                                    Value = categoryInfo.rssUrl
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
            return this.MapFrom((List<CategoryInfo>)input);
        }
    }
}