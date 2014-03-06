namespace Endjin.Web.MetaWeblog.Installers
{
    #region Using Directives

    using Endjin.Core.Container;
    using Endjin.Web.MetaWeblog.Contracts.Mappers;
    using Endjin.Web.MetaWeblog.Domain.MetaWeblog;
    using Endjin.Web.MetaWeblog.Mappers;
    using Endjin.Web.MetaWeblog.Mappers.XmlRpc.Request;

    #endregion 

    public class RequestMapperFactoryInstaller : IInstaller
    {
        public void Install(IContainer container)
        {
            var mapperFactory = new RequestMapperFactory();

            container.Register(Component.For<IRequestMapperFactory>().ImplementedBy(mapperFactory).AsSingleton());

            this.RegisterDefaultContent(mapperFactory);
        }

        private void RegisterDefaultContent(RequestMapperFactory requestMapperFactory)
        {
            requestMapperFactory.RegisterContentFor<XmlRpcRequestToGetUserBlogsRequestMapper>(MetaWeblogActions.GetUsersBlogs);
            requestMapperFactory.RegisterContentFor<XmlRpcRequestToGetCategoriesRequestMapper>(MetaWeblogActions.GetCategories);
            requestMapperFactory.RegisterContentFor<XmlRpcRequestToGetRecentPostsRequestMapper>(MetaWeblogActions.GetRecentPosts);
            requestMapperFactory.RegisterContentFor<XmlRpcRequestToNewPostRequestMapper>(MetaWeblogActions.NewPost);
        }
    }
}