namespace Endjin.Web.MetaWeblog.Contracts.Mappers
{
    public interface IMapper
    {
        object MapFrom(object input);
    }

    public interface IMapper<TInput, TOutput> : IMapper
    {
        TOutput MapFrom(TInput input);
    }
}