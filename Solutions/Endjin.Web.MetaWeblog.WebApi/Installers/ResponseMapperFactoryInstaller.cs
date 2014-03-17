namespace Endjin.Web.MetaWeblog.WebApi.Installers
{
    #region Using Directives

    using Endjin.Core.Container;
    using Endjin.Web.MetaWeblog.Domain.MetaWeblog;
    using Endjin.Web.MetaWeblog.WebApi.Contracts.Mappers;
    using Endjin.Web.MetaWeblog.WebApi.Mappers.Http;

    #endregion 

    public class ResponseMapperFactoryInstaller : IInstaller
    {
        public void Install(IContainer container)
        {
            var mapperFactory = new HttpResponseMessageMapperFactory();

            container.Register(Component.For<IHttpResponseMessageMapperFactory>().ImplementedBy(mapperFactory).AsSingleton());

            this.RegisterDefaultContent(mapperFactory);
        }

        private void RegisterDefaultContent(IHttpResponseMessageMapperFactory responseMapperFactory)
        {
            responseMapperFactory.RegisterContentFor<XmlRpcMetaDataResponseToHttpResponseMapper>(MetaWeblogActions.GetUsersBlogs);
            responseMapperFactory.RegisterContentFor<XmlRpcMetaDataResponseToHttpResponseMapper>(MetaWeblogActions.GetCategories);
            responseMapperFactory.RegisterContentFor<XmlRpcPostContentResponseToHttpResponseMapper>(MetaWeblogActions.GetRecentPosts);
            responseMapperFactory.RegisterContentFor<XmlRpcConfirmationResponseToHttpResponseMessageMapper>(MetaWeblogActions.NewPost);
            responseMapperFactory.RegisterContentFor<XmlRpcConfirmationResponseToHttpResponseMessageMapper>(MetaWeblogActions.DeletePost);
        }
    }
}