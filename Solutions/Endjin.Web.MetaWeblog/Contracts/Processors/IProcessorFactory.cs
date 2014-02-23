namespace Endjin.Web.MetaWeblog.Contracts.Processors
{
    using Endjin.Core.Composition.Contracts;

    public interface IProcessorFactory : IContentFactory<IProcessor>
    {
    }
}