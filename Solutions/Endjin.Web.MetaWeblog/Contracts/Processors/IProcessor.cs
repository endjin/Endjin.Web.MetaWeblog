namespace Endjin.Web.MetaWeblog.Contracts.Processors
{
    using System.Threading.Tasks;

    public interface IProcessor
    {
        Task<object> ProcessAsync(object input);
    }

    public interface IProcessor<TInput, TOutput> : IProcessor
    {
        Task<TOutput> ProcessAsync(TInput input);
    }
}