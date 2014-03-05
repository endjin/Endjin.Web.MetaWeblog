namespace Endjin.Web.MetaWeblog.Domain.MetaWeblog.Request
{
    public class NewPostRequest
    {
        public string BlogId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public string[] Categories { get; set; }

        public string Publish { get; set; }
    }
}
