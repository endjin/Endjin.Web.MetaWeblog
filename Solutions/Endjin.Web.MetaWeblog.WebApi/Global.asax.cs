namespace Endjin.Web.MetaWeblog.WebApi
{
    #region Using Directives

    using System.Web.Http;

    #endregion 

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configuration.Routes.AddHttpRoutes();
        }
    }
}
