namespace Endjin.Web.MetaWeblog.Domain.MetaWeblog.Response
{
    public class CategoryInfo
    {
        public int categoryid { get; set; }
        
        public string title { get; set; }
        
        public string description { get; set; }
        
        public string htmlUrl { get; set; }
        
        public string rssUrl { get; set; }
    }
}