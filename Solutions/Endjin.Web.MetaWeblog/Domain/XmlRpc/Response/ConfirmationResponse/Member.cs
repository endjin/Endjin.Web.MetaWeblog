namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.ConfirmationResponse
{
    using System.Xml.Serialization;

    #region Using Directives

    

    #endregion 

    public class Member
    {
        [XmlElement("name", Namespace = "")]
        public string Name { get; set; }

        [XmlElement("value", Namespace = "")]
        public MemberValue Value { get; set; }
    }
}