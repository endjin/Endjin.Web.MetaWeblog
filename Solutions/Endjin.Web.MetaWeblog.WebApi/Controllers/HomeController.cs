namespace Endjin.Web.MetaWeblog.WebApi.Controllers
{
    #region Using Directives

    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Web.Http;
    
    #endregion 

    public class HomeController : ApiController
    {
        public Task<HttpResponseMessage> GetAsync()
        {
            return Task.FromResult(this.Request.CreateResponse(HttpStatusCode.OK));
        }
    }
}