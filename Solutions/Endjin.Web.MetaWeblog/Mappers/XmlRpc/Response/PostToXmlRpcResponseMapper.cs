using System.Collections;
using System.Globalization;
using System.Net;
using System.Runtime.InteropServices.ComTypes;

namespace Endjin.Web.MetaWeblog.Mappers.XmlRpc.Response
{
    #region Using Directives

    using System.Collections.Generic;

    using Endjin.Web.MetaWeblog.Contracts.Mappers;
    using Endjin.Web.MetaWeblog.Domain.MetaWeblog.Response;
    using Endjin.Web.MetaWeblog.Domain.XmlRpc;

    #endregion
    public class PostToXmlRpcResponseMapper : IMapper<List<Post>, Response>
    {
        public Domain.XmlRpc.Response MapFrom(List<Post> input)
        {
            var response = new Domain.XmlRpc.Response();

            foreach (var post in input)
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
                                                    Value = post.postid
                                                }
                                            },
                                            new Member
                                            {
                                                Name = "dateCreated",
                                                Value = new MemberValue
                                                {
                                                    //ValueChoice = MemberValue.ValueType.DateTime,
                                                    //Value = post.dateCreated
                                                    ValueChoice = MemberValue.ValueType.Iso8601,
                                                    Value = post.dateCreated.ToString("yyyy-MM-ddTHH:mm:ss")
                                                }
                                            },
                                            new Member
                                            {
                                                Name = "title",
                                                Value = new MemberValue
                                                {
                                                    ValueChoice = MemberValue.ValueType.String,
                                                    Value = post.title
                                                }
                                            },
                                            new Member
                                            {
                                                Name = "description",
                                                Value = new MemberValue
                                                {
                                                    ValueChoice = MemberValue.ValueType.String,
                                                    Value = PCLWebUtility.WebUtility.HtmlEncode(post.description)
                                                }
                                            },
                                            new Member
                                            {
                                                Name = "link",
                                                Value = new MemberValue
                                                {
                                                    ValueChoice = MemberValue.ValueType.String,
                                                    Value = post.link
                                                }
                                            }
                                            ,
                                            new Member
                                            {
                                                Name = "publish",
                                                Value = new MemberValue
                                                {
                                                    ValueChoice = MemberValue.ValueType.String,
                                                    Value = post.publish.ToString()
                                                }
                                            },
                                            new Member
                                            {
                                                Name = "categories",
                                                Value = new MemberValue
                                                {
                                                    ValueChoice = MemberValue.ValueType.Array,
                                                    Value = GetCategories(post)
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

        private MemberValueArray GetCategories(Post post)
        {
            var categories = GetMemberValuesFromMemberValueArray(post);
            var array = new MemberValueArray()
            {
                Value = categories
            };

            return array;
        }

        private List<MemberValue> GetMemberValuesFromMemberValueArray(Post post)
        {
            var memberValueArrayValue = new List<MemberValue>();
            foreach (var category in post.categories)
            {
                memberValueArrayValue.Add(new MemberValue 
                {
                    ValueChoice = MemberValue.ValueType.String,
                    Value = category
                });
            }
            return memberValueArrayValue;
        }

        public object MapFrom(object input)
        {
            return this.MapFrom((List<Post>)input);
        }
    }
}