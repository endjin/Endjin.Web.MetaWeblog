using System.Xml.Serialization;

namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives

    

    #endregion 

    public class ResponseParam
    {
        [XmlElement("value", Namespace = "")]
        public ResponseData Value { get; set; }
    }
}