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

    public class GetUserBlogsProcessor : IProcessor<GetUserBlogsRequest, List<BlogInfo>>
    {
        public Task<List<BlogInfo>> ProcessAsync(GetUserBlogsRequest input)
        {
            // Note: Your real system integration would happen here.
            return Task.FromResult(new List<BlogInfo>
            {
                new BlogInfo
                {
                    BlogId = "1",
                    BlogName = "endjin blog",
                    Url = "http://localhost:7169/"
                }
            });
        }

        public async Task<object> ProcessAsync(object input)
        {
            return await this.ProcessAsync((GetUserBlogsRequest)input);
        }
    }

    /*
 
    Other Processors to implement
        
    int NewPost(string userName, string password, string blogid, Post post);
        
    void EditPost(string userName, string password, Post post);
        
    Post GetPost(string userName, string password, int postid);
        
    void DeletePost(string userName, string password, int postid);
        
    MediaObjectInfo NewMediaObject(string userName, string password, MediaObject mediaObject);
    
    */
}