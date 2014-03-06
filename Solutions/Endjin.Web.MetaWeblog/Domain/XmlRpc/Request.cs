namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives

    using System.Collections.Generic;
    using System.Xml.Serialization;

    #endregion 

    [XmlRoot("methodCall", Namespace = "")]
    public class Request
    {
        [XmlElement("methodName", Namespace = "")]
        public string Method { get; set; }

        [XmlArray("params", Namespace = "")] 
        [XmlArrayItem("param", Namespace = "")]
        public List<RequestParam> Params { get; set; }
    }
}