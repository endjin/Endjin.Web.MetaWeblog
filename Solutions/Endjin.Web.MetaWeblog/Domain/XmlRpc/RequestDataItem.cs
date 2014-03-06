namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
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