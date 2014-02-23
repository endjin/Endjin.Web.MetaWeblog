namespace Endjin.Web.MetaWeblog.Integration.Specs.Hooks
{
    #region Using Directives

    using System.Net.Http;
    using System.Web.Http;

    using Endjin.Core.Composition;
    using Endjin.Core.Composition.DependencyResolver;
    using Endjin.Web.MetaWeblog.Integration.Specs.Steps;
    using Endjin.Web.MetaWeblog.WebApi;

    using TechTalk.SpecFlow;

    #endregion

    [Binding]
    public class SetupHooks
    {
        [BeforeScenario]
        public static void SetUp()
        {
           var configuration = new HttpConfiguration();
           configuration.Routes.AddHttpRoutes();
           configuration.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;
           configuration.DependencyResolver = new ContainerDependencyResolver(ApplicationServiceLocator.Container);

            var server = new HttpServer(configuration);
            var client = new HttpClient(server);

            ScenarioContext.Current.Set(client, Keys.HttpClient);
        }
    }
}