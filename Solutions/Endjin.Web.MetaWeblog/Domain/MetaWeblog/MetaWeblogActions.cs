namespace Endjin.Web.MetaWeblog.Domain.MetaWeblog
{
    public static class MetaWeblogActions
    {
        public static string GetUsersBlogs
        {
            get { return "blogger.getUsersBlogs"; }
        }

        public static string GetCategories
        {
            get { return "metaWeblog.getCategories"; }
        }

        public static string GetRecentPosts
        {
            get { return "metaWeblog.getRecentPosts"; }
        }

        public static string NewPost
        {
            get { return "metaWeblog.newPost"; }
        }
    }
}