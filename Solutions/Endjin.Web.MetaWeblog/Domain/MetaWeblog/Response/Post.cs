namespace Endjin.Web.MetaWeblog.Domain.MetaWeblog.Response
{
    using System;

    public class Post
    {
        public int postid { get; set; }
        
        public string title { get; set; }
        
        public string description { get; set; }
        
        public string mt_text_more { get; set; }
        
        public string mt_keywords { get; set; }
        
        public string wp_slug { get; set; }
        
        public string mt_basename { get; set; }
        
        public string mt_excerpt { get; set; }
        
        public string wp_author_id { get; set; }
        
        public string[] categories { get; set; }
        
        public bool IsPublished { get; set; }
        
        public DateTime dateCreated { get; set; }
    }
}