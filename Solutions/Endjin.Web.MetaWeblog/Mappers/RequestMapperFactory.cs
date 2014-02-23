namespace Endjin.Web.MetaWeblog.Mappers
{
    #region Using Directives

    using Endjin.Core.Composition;
    using Endjin.Web.MetaWeblog.Contracts.Mappers;

    #endregion 

    public class RequestMapperFactory : ContentFactory<IMapper>, IRequestMapperFactory
    {
        private const string Extension = "+RequestMapper";

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