namespace Endjin.Web.MetaWeblog.Installers
{
    #region Using Directives

    using Endjin.Core.Container;
    using Endjin.Web.MetaWeblog.Contracts.Processors;
    using Endjin.Web.MetaWeblog.Processors;

    #endregion

    public class ProcessorFactoryInstaller : IInstaller
    {
        public void Install(IContainer container)
        {
            var processorFactory = new ProcessorFactory();

            container.Register(Component.For<IProcessorFactory>().ImplementedBy(processorFactory).AsSingleton());

            this.RegisterDefaultContent(processorFactory);
        }

        private void RegisterDefaultContent(IProcessorFactory processorFactory)
        {
            processorFactory.RegisterContentFor<GetUserBlogsProcessor>("blogger.getUsersBlogs");
            processorFactory.RegisterContentFor<GetCategoriesProcessor>("metaWeblog.getCategories");
            processorFactory.RegisterContentFor<GetRecentPostsProcessor>("metaWeblog.getRecentPosts");
            processorFactory.RegisterContentFor<NewPostProcessor>("metaWeblog.newPost");
        }

    }
}