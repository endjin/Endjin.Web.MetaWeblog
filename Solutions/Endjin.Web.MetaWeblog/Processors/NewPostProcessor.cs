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

    public class NewPostProcessor : IProcessor<NewPostRequest, List<PostId>>
    {
        public Task<List<PostId>> ProcessAsync(NewPostRequest input)
        {
            // Note: Your real system integration would happen here.

            ////Create a new blog post in Vellum
            // input.BlogId
            // input.title 
            // input.description 
            // input.link = 
            // //Need to loop through categories...
            // input.categories[] 
  
            ////Publish the post, if requested
            //input.Publish 

            //Return the id - the slug
            return Task.FromResult(new List<PostId>
            {
                new PostId
                {
                   Id = "/blogs/blog1",
                }
            });
        }

        public async Task<object> ProcessAsync(object input)
        {
            return await this.ProcessAsync((NewPostRequest)input);
        }
    }
}
