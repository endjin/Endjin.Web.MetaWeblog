namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
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