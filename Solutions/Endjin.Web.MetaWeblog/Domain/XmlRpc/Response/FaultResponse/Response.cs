namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.FaultResponse
{
    #region Using Directives

    using System.Collections.Generic;
    using System.Xml.Serialization;

    using Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.MetaDataResponse;

    #endregion 

    [XmlRoot("methodResponse", Namespace = "")]
    public class Response 
    {
        [XmlElement("fault", Namespace = "", IsNullable = true)]
        public Fault Fault { get; set; }
    }

}