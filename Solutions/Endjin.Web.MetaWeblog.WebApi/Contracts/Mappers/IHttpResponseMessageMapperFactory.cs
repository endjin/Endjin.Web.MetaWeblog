namespace Endjin.Web.MetaWeblog.WebApi.Contracts.Mappers
{
    using Endjin.Core.Composition.Contracts;
    using Endjin.Web.MetaWeblog.Contracts.Mappers;

    public interface IHttpResponseMessageMapperFactory : IContentFactory<IMapper>
    {
    }
}