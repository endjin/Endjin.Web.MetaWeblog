namespace Endjin.Web.MetaWeblog.Integration.Specs.Hooks
{
    #region Using Directives

    using TechTalk.SpecFlow;

    #endregion

    [Binding]
    public class TeardownHooks
    {
        [AfterScenario]
        public static void Teardown()
        {
            ContainerHooks.ShutdownContainer();
        }
    }
}