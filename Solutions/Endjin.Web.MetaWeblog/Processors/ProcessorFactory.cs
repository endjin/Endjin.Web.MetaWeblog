namespace Endjin.Web.MetaWeblog.Processors
{
    #region Using Directives

    using Endjin.Core.Composition;
    using Endjin.Web.MetaWeblog.Contracts.Processors;

    #endregion 

    public class ProcessorFactory : ContentFactory<IProcessor>, IProcessorFactory
    {
        private const string Extension = "+Processor";

        public override void RegisterContentFor<TInstance>(string contentType)
        {
            base.RegisterContentFor<TInstance>(contentType + Extension);
        }

        public override IProcessor GetContentFor(string contentType)
        {
            return base.GetContentFor(contentType + Extension);
        }
    }
}