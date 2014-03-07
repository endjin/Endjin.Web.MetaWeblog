namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.PostContentResponse
{
    #region Using Directives

    using System.Xml.Serialization;

    #endregion

    public class Member
    {
        [XmlElement("name", Namespace = "")]
        public string Name { get; set; }

        [XmlElement("value", Namespace = "")]
        public MemberValue Value { get; set; }

        // Or ResponseData and don't give it an attribute here? 
        public MemberCategoryValue Data { get; set; }
    }
}