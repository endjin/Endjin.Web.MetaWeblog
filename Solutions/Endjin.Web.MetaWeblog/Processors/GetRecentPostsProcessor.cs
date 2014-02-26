using System;

namespace Endjin.Web.MetaWeblog.Processors
{
    #region Using Directives

    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Endjin.Web.MetaWeblog.Contracts.Mappers;
    using Endjin.Web.MetaWeblog.Contracts.Processors;
    using Endjin.Web.MetaWeblog.Domain.MetaWeblog.Request;
    using Endjin.Web.MetaWeblog.Domain.MetaWeblog.Response;

    #endregion

    public class GetRecentPostsProcessor : IProcessor<GetRecentPostsRequest, List<Post>>
    {
        public Task<List<Post>> ProcessAsync(GetRecentPostsRequest input)
        {
            // Note: Your real system integration would happen here.
            // We need to check the number of posts requested in the GetRecentPostsRequest
            return Task.FromResult(new List<Post>
            {
                new Post
                {
                    postid = "blogs/firstblog",
                    dateCreated = DateTime.Parse("5/1/2014 8:30:52 AM", System.Globalization.CultureInfo.InvariantCulture),
                    title = "First Post",
                    //XML RPC puts descriptions in this format: &lt;p&gt;With a paragraph&lt;/p&gt; &lt;p&gt;And a &lt;a href="http://msdn.microsoft.com/en-us/library/aa691090(v=vs.71).aspx"&gt;link&lt;/a&gt;&lt;/p&gt;
                    //Should I build a helper which maps Vellum format blog content to the XML RPC description string? 
                    //description = @"&lt;p&gt;With a paragraph&lt;/p&gt; &lt;p&gt;And a &lt;a href=""http://msdn.microsoft.com/en-us/library/aa691090(v=vs.71).aspx""&gt;link&lt;/a&gt;&lt;/p&gt;",
                    description = "back to a simple description",       link = "blogs/firstblog",
                    categories = new string[]{"Cloud", "Apprenticeships"},
                    publish = false
                }
            });
        }

        public async Task<object> ProcessAsync(object input)
        {
            return await this.ProcessAsync((GetRecentPostsRequest)input);
        }
    }
}