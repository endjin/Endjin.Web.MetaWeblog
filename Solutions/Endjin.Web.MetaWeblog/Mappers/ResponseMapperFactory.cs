namespace Endjin.Web.MetaWeblog.Mappers
{
    #region Using Directives

    using Endjin.Core.Composition;
    using Endjin.Web.MetaWeblog.Contracts.Mappers;

    #endregion 

    public class ResponseMapperFactory : ContentFactory<IMapper>, IResponseMapperFactory
    {
        private const string Extension = "+ResponseMapper";

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