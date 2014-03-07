namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.PostContentResponse
{
    using System.Xml;
    using System.Xml.Serialization;

    public class MemberCategoryValue
    {
        [XmlElement("value", Namespace = "")]
        public ResponseData Value { get; set; }
    }
}