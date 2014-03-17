namespace Endjin.Web.MetaWeblog.Processors
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Endjin.Web.MetaWeblog.Contracts.Processors;
    using Endjin.Web.MetaWeblog.Domain.MetaWeblog.Request;
    using Endjin.Web.MetaWeblog.Domain.MetaWeblog.Response;

    public class DeletePostProcessor : IProcessor<DeletePostRequest, List<DeletionConfirmation>>
    {
        public Task<List<DeletionConfirmation>> ProcessAsync(DeletePostRequest input)
        {
            // Note: Your real system integration would happen here.
            return Task.FromResult(new List<DeletionConfirmation> { new DeletionConfirmation { Confirmation = 1, } });
        }

        public async Task<object> ProcessAsync(object input)
        {
            return await this.ProcessAsync((DeletePostRequest)input);
        }
    }
}
