namespace Endjin.Web.MetaWeblog.Processors
{
    #region Using Directives

    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System;
    using System.Net;
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
                    description = PCLWebUtility.WebUtility.HtmlEncode("<p>back to a simple description including a <a href=\"http://www.thing.com/\">link</a></p>").Replace("\"", "&quot;"),
                    link = "blogs/firstblog",
                    categories = new[] { "Cloud", "Apprenticeships" },
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