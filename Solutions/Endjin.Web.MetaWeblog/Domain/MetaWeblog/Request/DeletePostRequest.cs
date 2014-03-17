namespace Endjin.Web.MetaWeblog.Domain.MetaWeblog.Request
{
    public class DeletePostRequest
    {
        public string AppKey { get; set; }

        public string PostId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}