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

    public class GetCategoriesProcessor : IProcessor<GetCategoriesRequest, List<CategoryInfo>>
    {
        public Task<List<CategoryInfo>> ProcessAsync(GetCategoriesRequest input)
        {
            // Note: Your real system integration would happen here.
            return Task.FromResult(new List<CategoryInfo>
            {
                new CategoryInfo
                {
                    categoryid = 1,
                    title = "Cloud",
                    description = "Cloud",
                    htmlUrl = "http://www.endjin.com/blog/category?cloud",
                    rssUrl = "http://www.endjin.com/blog/rss?category?cloud"
                }
            });
        }

        public async Task<object> ProcessAsync(object input)
        {
            return await this.ProcessAsync((GetCategoriesRequest)input);
        }
    }

    /*
 
    Other Processors to implement
        
    IEnumerable<Post> GetRecentPosts(string userName, string password, string blogid, int noOfPosts);
        
    IEnumerable<CategoryInfo> GetCategories(string userName, string password);
        
    int NewPost(string userName, string password, string blogid, Post post);
        
    void EditPost(string userName, string password, Post post);
        
    Post GetPost(string userName, string password, int postid);
        
    void DeletePost(string userName, string password, int postid);
        
    MediaObjectInfo NewMediaObject(string userName, string password, MediaObject mediaObject);
    
    */
}