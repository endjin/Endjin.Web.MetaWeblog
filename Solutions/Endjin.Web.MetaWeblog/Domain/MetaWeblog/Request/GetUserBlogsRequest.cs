namespace Endjin.Web.MetaWeblog.Domain.MetaWeblog.Request
{
    public class GetUserBlogsRequest
    {
        public string AppKey { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}