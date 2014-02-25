namespace Endjin.Web.MetaWeblog.Installers
{
    #region Using Directives

    using Endjin.Core.Container;
    using Endjin.Web.MetaWeblog.Contracts.Mappers;
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
            responseMapperFactory.RegisterContentFor<BlogInfoToXmlRpcResponseMapper>("blogger.getUsersBlogs");
            responseMapperFactory.RegisterContentFor<CategoryInfoToXmlRpcResponseMapper>("metaWeblog.getCategories");
            responseMapperFactory.RegisterContentFor<PostToXmlRpcResponseMapper>("metaWeblog.getRecentPosts");
        }
    }
}