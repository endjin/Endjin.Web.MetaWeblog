namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.ConfirmationResponse
{
    #region Using Directives

    using System.Xml.Serialization;

    #endregion 

    public class ResponseDataItem
    {
        [XmlElement("value", Namespace = "")]
        public ResponseParamValue Value { get; set; }
    }
}