namespace Endjin.Web.MetaWeblog.Installers
{
    #region Using Directives

    using Endjin.Core.Container;
    using Endjin.Web.MetaWeblog.Contracts.Processors;
    using Endjin.Web.MetaWeblog.Domain.MetaWeblog;
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
            processorFactory.RegisterContentFor<GetUserBlogsProcessor>(MetaWeblogActions.GetUsersBlogs);
            processorFactory.RegisterContentFor<GetCategoriesProcessor>(MetaWeblogActions.GetCategories);
            processorFactory.RegisterContentFor<GetRecentPostsProcessor>(MetaWeblogActions.GetRecentPosts);
            processorFactory.RegisterContentFor<NewPostProcessor>(MetaWeblogActions.NewPost);
        }
    }
}