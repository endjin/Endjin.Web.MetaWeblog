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
            return Task.FromResult(new List<Post>
            {
                new Post
                {
                    postid = "blogs/firstblog",
                    dateCreated = DateTime.Parse("5/1/2014 8:30:52 AM", System.Globalization.CultureInfo.InvariantCulture),
                    title = "First Post",
                    description = "Here's the content of the post. We might even add html, including a link, and a picture in later",
                    link = "blogs/firstblog",
                    //Does category need to be a domain object rather than an array? No, the category information provided in response to getRecentPosts is different to CategoryInfo 
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