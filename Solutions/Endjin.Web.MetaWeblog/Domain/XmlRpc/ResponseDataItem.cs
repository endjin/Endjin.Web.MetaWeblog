using System.Xml.Serialization;

namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives

    

    #endregion 

    public class ResponseDataItem
    {
        [XmlElement("value", Namespace = "")]
        public ResponseParamValue Value { get; set; }
    }
}