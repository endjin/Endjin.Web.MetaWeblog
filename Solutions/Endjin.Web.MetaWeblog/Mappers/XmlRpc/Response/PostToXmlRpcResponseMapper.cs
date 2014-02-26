using System.Globalization;
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
                                                    ValueChoice = MemberValue.ValueType.@string,
                                                    Value = post.postid
                                                }
                                            },
                                            new Member
                                            {
                                                Name = "dateCreated",
                                                Value = new MemberValue
                                                {
                                                    ValueChoice = MemberValue.ValueType.datetime,
                                                    Value = post.dateCreated
                                                }
                                            },
                                            new Member
                                            {
                                                Name = "title",
                                                Value = new MemberValue
                                                {
                                                    ValueChoice = MemberValue.ValueType.@string,
                                                    Value = post.title
                                                }
                                            },
                                            new Member
                                            {
                                                Name = "description",
                                                Value = new MemberValue
                                                {
                                                    ValueChoice = MemberValue.ValueType.@string,
                                                    Value = post.description
                                                }
                                            },
                                            new Member
                                            {
                                                Name = "link",
                                                Value = new MemberValue
                                                {
                                                    ValueChoice = MemberValue.ValueType.@string,
                                                    Value = post.link
                                                }
                                            }
                                            ,
                                            new Member
                                            {
                                                Name = "publish",
                                                Value = new MemberValue
                                                {
                                                    ValueChoice = MemberValue.ValueType.@string,
                                                    Value = post.publish.ToString()
                                                }
                                            },
                                            new Member
                                            {
                                                Name = "categories",
                                                Value = new MemberValue
                                                {
                                                    MemberValueArray = new MemberValueArray()
                                                    {
                                                        Value = GetMemberValuesFromMemberValueArray(post)
                                                        //Value = new List<MemberValue>
                                                        //{
                                                        //    GetMemberValuesFromMemberValueArray(post)//foreach (var xcategory in post.categories)
                                                            //{
                                                            //new MemberValue()
                                                            //{
                                                            //    ValueChoice = MemberValue.ValueType.@string,
                                                            //    Value = post.categories[0]
                                                            //}}
                                                        //}

                                                    }
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

        private List<MemberValue> GetMemberValuesFromMemberValueArray(Post post)
        {
            var memberValueArrayValue = new List<MemberValue>();
            foreach (var category in post.categories)
            {
                memberValueArrayValue.Add(new MemberValue 
                {
                    ValueChoice = MemberValue.ValueType.@string,
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