namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.MetaDataResponse
{
    #region Using Directives

    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    #endregion

    //[DataContract(Namespace = "")]
    public class Member
    {
        [XmlElement("name", Namespace = "")]
        public string Name { get; set; }

        [XmlElement("value", Namespace = "")]
        public MemberValue Value { get; set; }
    }
}