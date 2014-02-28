using System.Xml.Serialization;

namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives

    

    #endregion 

    [XmlRoot("methodResponse", Namespace = "")]
    public class VersionResult
    {
        [XmlElement("faultString", Namespace = "")]
        public string FaultString { get; set; }

        [XmlElement("faultCode", Namespace = "")]
        public string FaultCode { get; set; }

        [XmlElement("version", Namespace = "")]
        public string Version { get; set; }
    }
}