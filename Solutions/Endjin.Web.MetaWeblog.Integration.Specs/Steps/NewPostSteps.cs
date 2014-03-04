﻿using System;
using System.Collections.Generic;
using Endjin.Web.MetaWeblog.Domain.XmlRpc;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

using System.Linq;
using NUnit.Framework;


namespace Endjin.Web.MetaWeblog.Integration.Specs.Steps
{
    [Binding]
    public class NewPostSteps
    {

        [Given(@"I want to be able to add a new blog post to the site, with the title ""(.*)"", the description ""(.*)"", and the categories ""(.*)""")]
        public void GivenIWantToBeAbleToAddANewBlogPostToTheSiteWithTheTitleTheDescriptionAndTheCategories(string title, string description, string csvCategories)
        {
            var xmlRpc = ScenarioContext.Current.Get<Request>(Keys.XmlRpcRequest);

            xmlRpc.Method = "metaWeblog.newPost";

            string[] categories = csvCategories.Split(',');

            var param = new RequestParam
            {
                RequestValue =
                {
                    Member = new List<Member>
                                        {
                                            new Member
                                            {
                                                Name = "title",
                                                Value = new MemberValue
                                                {
                                                    ValueChoice = MemberValue.ValueType.String,
                                                    Value = title 
                                                }
                                            },
                                            new Member
                                            {
                                                Name = "description",
                                                Value = new MemberValue
                                                {
                                                    ValueChoice = MemberValue.ValueType.String,
                                                    Value = description 
                                                }
                                            },
                                            new Member
                                            {
                                                Name = "categories",
                                                Value = new MemberValue
                                                {
                                                    ValueChoice = MemberValue.ValueType.Array,
                                                    Value = new MemberValueArray
                                                    {
                                                        Value = categories.Select(category => new MemberValue
                                                        {
                                                            ValueChoice = MemberValue.ValueType.String, Value = category
                                                        }).ToList()
                                                    }
                                                }
                                            }
                                        }
                }
            };

            xmlRpc.Params.Add(param);

            ScenarioContext.Current.Set(xmlRpc, Keys.XmlRpcRequest);
        }

        [Given(@"it should be added as a draft")]
        public void GivenItShouldBeAddedAsADraft()
        {
            var xmlRpc = ScenarioContext.Current.Get<Request>(Keys.XmlRpcRequest);

            var param = new RequestParam
            {
                RequestValue =
                    {
                        ValueChoice = MemberValue.ValueType.String,
                        Value = "false"
                    }
            };
            xmlRpc.Params.Add(param);

            ScenarioContext.Current.Set(xmlRpc, Keys.XmlRpcRequest);
        }

        [Given(@"it should be published")]
        public void GivenItShouldBePublished()
        {
            var xmlRpc = ScenarioContext.Current.Get<Request>(Keys.XmlRpcRequest);

            var param = new RequestParam
            {
                RequestValue =
                {
                    ValueChoice = MemberValue.ValueType.String,
                    Value = "true"
                }
            };
            xmlRpc.Params.Add(param);

            ScenarioContext.Current.Set(xmlRpc, Keys.XmlRpcRequest);
        }


        [Then(@"the post should be added to the site as a draft")]
        public void ThenThePostShouldBeAddedToTheSiteAsADraft()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the post should be added to the site and published")]
        public void ThenThePostShouldBeAddedToTheSiteAndPublished()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
