namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives

    using System.Collections.Generic;
    using System.Xml.Serialization;

    using Endjin.Web.MetaWeblog.Domain.XmlRpc.Request;

    #endregion 

    [XmlRoot("methodCall", Namespace = "")]
    public class RequestTop
    {
        [XmlElement("methodName", Namespace = "")]
        public string Method { get; set; }

        [XmlArray("params", Namespace = "")] 
        [XmlArrayItem("param", Namespace = "")]
        public List<RequestParam> Params { get; set; }
    }
}