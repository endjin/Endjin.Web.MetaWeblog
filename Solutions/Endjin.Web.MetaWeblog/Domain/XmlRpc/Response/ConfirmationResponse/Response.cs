namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.ConfirmationResponse
{
    #region Using Directives

    using System.Collections.Generic;
    using System.Xml.Serialization;

    using Endjin.Web.MetaWeblog.Contracts.Domain;
    using Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.FaultResponse;

    #endregion 

    [XmlRoot("methodResponse", Namespace = "")]
    public class Response : IResponse
    {
        private List<ResponseParams> responseParams;

        [XmlElement("params", Namespace = "")]
        public List<ResponseParams> Params
        {
            get { return this.responseParams ?? (this.Params = new List<ResponseParams>()); }
            set { this.responseParams = value; }
        }
    }

}