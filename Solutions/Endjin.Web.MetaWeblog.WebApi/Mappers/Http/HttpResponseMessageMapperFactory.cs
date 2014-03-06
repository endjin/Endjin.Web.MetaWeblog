namespace Endjin.Web.MetaWeblog.WebApi.Mappers.Http
{
    #region Using Directives

    using Endjin.Core.Composition;
    using Endjin.Web.MetaWeblog.Contracts.Mappers;
    using Endjin.Web.MetaWeblog.WebApi.Contracts.Mappers;

    #endregion 

    public class HttpResponseMessageMapperFactory : ContentFactory<IMapper>, IHttpResponseMessageMapperFactory
    {
        private const string Extension = "+HttResponseMessageMapper";

        public override void RegisterContentFor<TInstance>(string contentType)
        {
            base.RegisterContentFor<TInstance>(contentType + Extension);
        }

        public override IMapper GetContentFor(string contentType)
        {
            return base.GetContentFor(contentType + Extension);
        }
    }
}