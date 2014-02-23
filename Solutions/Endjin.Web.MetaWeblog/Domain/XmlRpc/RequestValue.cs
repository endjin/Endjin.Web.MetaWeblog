namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives

    using System.Xml.Serialization;

    #endregion 

    public class RequestValue
    {
        [XmlElement("string", Namespace = "")]
        public string String { get; set; }
    }
}