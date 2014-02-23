namespace Endjin.Web.MetaWeblog.Integration.Specs.Hooks
{
    #region Using Directives

    using System;
    using System.Diagnostics;

    using Endjin.Core.Composition;
    using Endjin.Core.Container;

    using TechTalk.SpecFlow;

    #endregion

    [Binding]
    public class ContainerHooks
    {
        [BeforeScenario]
        public static void InitialiseContainer()
        {
            if (ApplicationServiceLocator.IsInitialized)
            {
                return;
            }

            try
            {
                ApplicationServiceLocator.InitializeAsync(new Container(), new DesktopBootstrapper()).Wait();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public static void ShutdownContainer()
        {
            ApplicationServiceLocator.Shutdown();
        }
    }
}