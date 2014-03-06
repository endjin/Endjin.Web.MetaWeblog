namespace Endjin.Web.MetaWeblog.Installers
{
    #region Using Directives

    using Endjin.Core.Container;
    using Endjin.Web.MetaWeblog.Contracts.Mappers;
    using Endjin.Web.MetaWeblog.Domain.MetaWeblog;
    using Endjin.Web.MetaWeblog.Mappers;
    using Endjin.Web.MetaWeblog.Mappers.XmlRpc.Response;

    #endregion 

    public class ResponseMapperFactoryInstaller : IInstaller
    {
        public void Install(IContainer container)
        {
            var mapperFactory = new ResponseMapperFactory();

            container.Register(Component.For<IResponseMapperFactory>().ImplementedBy(mapperFactory).AsSingleton());

            this.RegisterDefaultContent(mapperFactory);
        }

        private void RegisterDefaultContent(IResponseMapperFactory responseMapperFactory)
        {
            responseMapperFactory.RegisterContentFor<BlogInfoToXmlRpcResponseMapper>(MetaWeblogActions.GetUsersBlogs);
            responseMapperFactory.RegisterContentFor<CategoryInfoToXmlRpcResponseMapper>(MetaWeblogActions.GetCategories);
            responseMapperFactory.RegisterContentFor<PostToXmlRpcResponseMapper>(MetaWeblogActions.GetRecentPosts);
            responseMapperFactory.RegisterContentFor<PostIdToXmlRpcResponseMapper>(MetaWeblogActions.NewPost);
        }
    }
}