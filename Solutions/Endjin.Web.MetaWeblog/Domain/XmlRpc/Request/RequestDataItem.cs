namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Request
{
    #region Using Directives

    using System.Xml.Serialization;

    #endregion

    public class RequestDataItem
    {
        [XmlElement("value", Namespace = "")]
        public RequestParamValue Value { get; set; }
    }
}